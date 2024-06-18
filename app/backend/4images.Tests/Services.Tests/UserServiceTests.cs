using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using _4images.Data;
using _4images.Models;
using _4images.Services;
using Microsoft.Extensions.Configuration;

namespace _4images.Tests.Services.Tests
{
    public class UserServiceTests
    {
        private readonly DbContextOptions<ApplicationDbContext> _options;
        private readonly IConfiguration _configuration;
        private readonly string _secretKey;

        public UserServiceTests()
        {
            // Configura o banco de dados em memória para os testes
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Carrega a configuração do arquivo appsettings.json
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // Carrega a secretKey para a aplicação
            _secretKey = _configuration["Jwt:SecretKey"];
        }

        private ApplicationDbContext CreateContext()
        {
            var context = new ApplicationDbContext(_options);
            context.Database.EnsureDeleted(); // Garante que o banco de dados em memória seja limpo
            context.Database.EnsureCreated();
            return context;
        }

        private UserService CreateUserService(ApplicationDbContext context)
        {
            var tokenService = new TokenService(_secretKey);
            return new UserService(context, tokenService);
        }

        [Fact]
        public async Task GetUsersAsync_ReturnAllUsers()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                // Dados dos usuários de teste
                var users = new List<User>
                {
                    new User { FullName = "Nome1 Sobrenome", Email = "user1@gmail.com", Password = "123", UserName = "user1", Signature = SignatureType.silver },
                    new User { FullName = "Nome2 Sobrenome", Email = "user2@gmail.com", Password = "321", UserName = "user2", Signature = SignatureType.cooper }
                };

                context.Users.AddRange(users);
                await context.SaveChangesAsync();

                // Pegar resultado
                var result = await userService.GetUsersAsync();

                // Assert
                Assert.Equal(2, result.Count());
            }
        }

        [Fact]
        public async Task GetUserByIdAsync_ReturnsCorrectUser()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                var user = new User { FullName = "Nome1 Sobrenome", Email = "user1@gmail.com", Password = "123", UserName = "user1", Signature = SignatureType.silver };
                context.Users.Add(user);
                await context.SaveChangesAsync();

                var result = await userService.GetUserByIdAsync(user.Id);

                Assert.NotNull(result);
                Assert.Equal(user.FullName, result.FullName);
            }
        }

        [Fact]
        public async Task CreateUserAsync_CreatesUserSuccessfully()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                var user = new User { FullName = "Nome1 Sobrenome", Email = "user1@gmail.com", Password = "123", UserName = "user1", Signature = SignatureType.silver };

                var result = await userService.CreateUserAsync(user);

                Assert.NotNull(result);
                Assert.Equal(user.FullName, result.FullName);
                Assert.NotEqual("123", result.Password); // Ensure password is hashed
            }
        }

        [Fact]
        public async Task UpdateUserAsync_UpdatesUserSuccessfully()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                var user = new User { FullName = "Nome1 Sobrenome", Email = "user1@gmail.com", Password = "123", UserName = "user1", Signature = SignatureType.silver };
                context.Users.Add(user);
                await context.SaveChangesAsync();

                user.FullName = "Updated Name";
                var result = await userService.UpdateUserAsync(user);

                Assert.NotNull(result);
                Assert.Equal("Updated Name", result.FullName);
            }
        }

        [Fact]
        public async Task DeleteUserAsync_DeletesUserSuccessfully()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                var user = new User { FullName = "Nome1 Sobrenome", Email = "user1@gmail.com", Password = "123", UserName = "user1", Signature = SignatureType.silver };
                context.Users.Add(user);
                await context.SaveChangesAsync();

                var result = await userService.DeleteUserAsync(user.Id);

                Assert.True(result);
                Assert.Null(await context.Users.FindAsync(user.Id));
            }
        }

        [Fact]
        public async Task AuthenticateAsync_ReturnsTokenForValidUser()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                var user = new User { FullName = "Nome1 Sobrenome", Email = "user1@gmail.com", Password = "12345678", UserName = "user1", Signature = SignatureType.silver };
                var createdUser = await userService.CreateUserAsync(user);

                // Log para verificar se o usuário foi criado corretamente
                var userFromDb = await context.Users.FindAsync(createdUser.Id);
                Assert.NotNull(userFromDb);
                Assert.NotEqual("12345678", userFromDb.Password); // Verifica se a senha foi hashada
                Console.WriteLine($"Senha armazenada no DB: {userFromDb.Password}");

                // Tentar autenticar o usuário
                var token = await userService.AuthenticateAsync(user.FullName, "12345678");

                Assert.NotNull(token);
                Console.WriteLine($"Token gerado: {token}");
            }
        }


        [Fact]
        public async Task AuthenticateAsync_ReturnsNullForInvalidUser()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                var user = new User { FullName = "Nome1 Sobrenome", Email = "user1@gmail.com", Password = "123", UserName = "user1", Signature = SignatureType.silver };
                await userService.CreateUserAsync(user);

                var token = await userService.AuthenticateAsync(user.FullName, "wrongpassword");

                Assert.Null(token);
            }
        }

        [Fact]
        public async Task GetUserByGoogleIdAsync_ReturnsCorrectUser()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                var user = new User { FullName = "Nome1 Sobrenome", Email = "user1@gmail.com", GoogleId = "google123", UserName = "user1", Signature = SignatureType.silver };
                context.Users.Add(user);
                await context.SaveChangesAsync();

                var result = await userService.GetUserByGoogleIdAsync("google123");

                Assert.NotNull(result);
                Assert.Equal(user.FullName, result.FullName);
            }
        }

        [Fact]
        public async Task CreateUserFromGoogleAsync_CreatesUserSuccessfully()
        {
            using (var context = CreateContext())
            {
                var userService = CreateUserService(context);

                var result = await userService.CreateUserFromGoogleAsync("Nome1 Sobrenome", "user1@gmail.com", "google123");

                Assert.NotNull(result);
                Assert.Equal("Nome1 Sobrenome", result.FullName);
                Assert.Equal("google123", result.GoogleId);
                Assert.Equal(SignatureType.cooper, result.Signature); // Ensure default signature is set
            }
        }
    }
}

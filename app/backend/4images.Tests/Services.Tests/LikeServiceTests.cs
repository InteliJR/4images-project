using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using _4images.Data;
using _4images.Models;
using _4images.Services;

namespace _4images.Tests.Services.Tests
{
    public class LikeServiceTests
    {
        private readonly DbContextOptions<ApplicationDbContext> _options;

        public LikeServiceTests()
        {
            // Configura o banco de dados em memória para os testes
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
        }

        private ApplicationDbContext CreateContext()
        {
            var context = new ApplicationDbContext(_options);
            context.Database.EnsureDeleted(); // Garante que o banco de dados em memória seja limpo
            context.Database.EnsureCreated();
            return context;
        }

        private LikeService CreateLikeService(ApplicationDbContext context)
        {
            return new LikeService(context);
        }

        [Fact]
        public async Task GetLikesAsync_ReturnsAllLikes()
        {
            using (var context = CreateContext())
            {
                var likeService = CreateLikeService(context);

                // Dados dos likes de teste
                var likes = new List<Like>
                {
                    new Like { UserId = 1, ImageId = 1 },
                    new Like { UserId = 2, ImageId = 1 }
                };

                context.Likes.AddRange(likes);
                await context.SaveChangesAsync();

                // Pegar resultado
                var result = await likeService.GetLikesAsync();

                // Assert
                Assert.Equal(2, result.Count());
            }
        }

        [Fact]
        public async Task GetLikeByIdAsync_ReturnsCorrectLike()
        {
            using (var context = CreateContext())
            {
                var likeService = CreateLikeService(context);

                var like = new Like { UserId = 1, ImageId = 1 };
                context.Likes.Add(like);
                await context.SaveChangesAsync();

                var result = await likeService.GetLikeByIdAsync(like.Id);

                Assert.NotNull(result);
                Assert.Equal(like.UserId, result.UserId);
                Assert.Equal(like.ImageId, result.ImageId);
            }
        }

        [Fact]
        public async Task GetLikeByUserAsync_ReturnsLikesForUser()
        {
            using (var context = CreateContext())
            {
                var likeService = CreateLikeService(context);

                var likes = new List<Like>
                {
                    new Like { UserId = 1, ImageId = 1 },
                    new Like { UserId = 1, ImageId = 2 },
                    new Like { UserId = 2, ImageId = 1 }
                };

                context.Likes.AddRange(likes);
                await context.SaveChangesAsync();

                var result = await likeService.GetLikeByUserAsync(1);

                Assert.Equal(2, result.Count());
            }
        }

        [Fact]
        public async Task GetLikeByImageAsync_ReturnsLikesForImage()
        {
            using (var context = CreateContext())
            {
                var likeService = CreateLikeService(context);

                var likes = new List<Like>
                {
                    new Like { UserId = 1, ImageId = 1 },
                    new Like { UserId = 2, ImageId = 1 },
                    new Like { UserId = 1, ImageId = 2 }
                };

                context.Likes.AddRange(likes);
                await context.SaveChangesAsync();

                var result = await likeService.GetLikeByImageAsync(1);

                Assert.Equal(2, result.Count());
            }
        }

        [Fact]
        public async Task CreateLikeAsync_CreatesLikeSuccessfully()
        {
            using (var context = CreateContext())
            {
                var likeService = CreateLikeService(context);

                // Criar um usuário de teste
                var user = new User { FullName = "Test User", UserName = "Nome Teste", Email = "test@example.com", Password = "password" };
                context.Users.Add(user);
                await context.SaveChangesAsync();

                // Criar um like de teste
                var like = new Like { UserId = user.Id, ImageId = 1 };

                var result = await likeService.CreateLikeAsync(like);

                Assert.NotNull(result);
                Assert.Equal(like.UserId, result.UserId);
                Assert.Equal(like.ImageId, result.ImageId);
            }
        }
    }
}




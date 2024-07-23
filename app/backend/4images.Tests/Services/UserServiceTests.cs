using Moq;
using Microsoft.EntityFrameworkCore;
using _4images.Data;
using _4images.Models;
using _4images.Services;
using NUnit.Framework.Legacy;
using System.Security.Cryptography;
using System.Text;

namespace _4images.Tests.Services
{
    [TestFixture]
    public class UserServiceTests
    {
        private ApplicationDbContext _context;
        private UserService _userService;
        private Mock<TokenService> _mockTokenService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _mockTokenService = new Mock<TokenService>("SecretKeyMuitoSecretaEssaChaveAAAAAAA");
            _userService = new UserService(_context, _mockTokenService.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

         [Test]
        public async Task CreateUserAsync_ShouldAddUserAndReturnUser()
        {
            // Arrange
            var user = new User
            {
                FullName = "Luigi Local Lanches",
                UserName = "Luigi",
                Email = "luigipatrao@example.com",
                Password = "o dogão da local lanches é foda de verdade",
                Signature = "localLanches"
            };

            // Act
            var createdUser = await _userService.CreateUserAsync(user);

            // Assert
            ClassicAssert.IsNotNull(createdUser);
            ClassicAssert.AreEqual("Luigi Local Lanches", createdUser.FullName);
            ClassicAssert.AreEqual("Luigi", createdUser.UserName);
            ClassicAssert.AreEqual("luigipatrao@example.com", createdUser.Email);

            var usersInDb = await _context.Users.ToListAsync();
            ClassicAssert.AreEqual(1, usersInDb.Count);
            ClassicAssert.AreEqual("Luigi Local Lanches", usersInDb[0].FullName);
        }

        [Test]
        public async Task GetUsersAsync_ShouldReturnAllUsers()
        {
            // Arrange
            var user1 = new User { FullName = "User One", UserName = "user1", Email = "user1@example.com", Password = "password1", Signature = "signature1" };
            var user2 = new User { FullName = "User Two", UserName = "user2", Email = "user2@example.com", Password = "password2", Signature = "signature2" };
            _context.Users.AddRange(user1, user2);
            await _context.SaveChangesAsync();

            // Act
            var users = await _userService.GetUsersAsync();

            // Assert
            ClassicAssert.AreEqual(2, users.Count());
            ClassicAssert.IsTrue(users.Any(u => u.FullName == "User One"));
            ClassicAssert.IsTrue(users.Any(u => u.FullName == "User Two"));
        }

        [Test]
        public async Task GetUserByIdAsync_ShouldReturnUser()
        {
            // Arrange
            var user = new User { FullName = "User", UserName = "user", Email = "user@example.com", Password = "password", Signature = "signature" };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Act
            var fetchedUser = await _userService.GetUserByIdAsync(user.Id);

            // Assert
            ClassicAssert.IsNotNull(fetchedUser);
            ClassicAssert.AreEqual("User", fetchedUser.FullName);
        }

        [Test]
        public async Task UpdateUserAsync_ShouldUpdateUser()
        {
            // Arrange
            var user = new User { FullName = "User", UserName = "user", Email = "user@example.com", Password = "password", Signature = "signature" };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            user.FullName = "Updated User";
            user.Email = "updated@example.com";

            // Act
            var updatedUser = await _userService.UpdateUserAsync(user);

            // Assert
            ClassicAssert.IsNotNull(updatedUser);
            ClassicAssert.AreEqual("Updated User", updatedUser.FullName);
            ClassicAssert.AreEqual("updated@example.com", updatedUser.Email);
        }

        [Test]
        public async Task DeleteUserAsync_ShouldRemoveUser()
        {
            // Arrange
            var user = new User { FullName = "User", UserName = "user", Email = "user@example.com", Password = "password", Signature = "signature" };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Act
            var result = await _userService.DeleteUserAsync(user.Id);

            // Assert
            ClassicAssert.IsTrue(result);
            ClassicAssert.IsNull(await _context.Users.FindAsync(user.Id));
        }

        // [Test]
        // public async Task AuthenticateAsync_ShouldReturnNullWhenCredentialsAreInvalid()
        // {
        //     // Arrange
        //     var user = new User
        //     {
        //         FullName = "Invalid User",
        //         Email = "invaliduser@example.com",
        //         Password = _userService.HashPassword("validpassword", out _),
        //         Signature = "signature"
        //     };
        //     _context.Users.Add(user);
        //     await _context.SaveChangesAsync();

        //     // Act   
        //     var token = await _userService.AuthenticateAsync(user.FullName, "wrongpassword");

        //     // Assert
        //     ClassicAssert.IsNull(token);
        // }

        [Test]
        public async Task GetUserByGoogleIdAsync_ShouldReturnUser()
        {
            // Arrange
            var user = new User { FullName = "Google User", GoogleId = "google-id", Email = "googleuser@example.com", Signature = "signature" };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Act
            var fetchedUser = await _userService.GetUserByGoogleIdAsync("google-id");

            // Assert
            ClassicAssert.IsNotNull(fetchedUser);
            ClassicAssert.AreEqual("Google User", fetchedUser.FullName);
        }

        [Test]
        public async Task CreateUserFromGoogleAsync_ShouldCreateUser()
        {
            // Act
            var user = await _userService.CreateUserFromGoogleAsync("Google User", "googleuser@example.com", "google-id");

            // Assert
            ClassicAssert.IsNotNull(user);
            ClassicAssert.AreEqual("Google User", user.FullName);
            ClassicAssert.AreEqual("googleuser@example.com", user.Email);
            ClassicAssert.AreEqual("google-id", user.GoogleId);
        }
    }
}

using Moq;
using Microsoft.EntityFrameworkCore;
using _4images.Data;
using _4images.Models;
using _4images.Services;
using NUnit.Framework.Legacy;

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
    }
}

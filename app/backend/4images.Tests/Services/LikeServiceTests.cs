using Moq;
using Microsoft.EntityFrameworkCore;
using _4images.Data;
using _4images.Models;
using _4images.Services;
using NUnit.Framework.Legacy;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4images.Tests.Services
{
    [TestFixture]
    public class LikeServiceTests
    {
        private ApplicationDbContext _context;
        private LikeService _likeService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _likeService = new LikeService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public async Task GetLikesAsync_ShouldReturnAllLikes()
        {
            // Arrange
            var like = new Like { UserId = 1, ImageId = 1 };
            _context.Likes.Add(like);
            await _context.SaveChangesAsync();

            // Act
            var result = await _likeService.GetLikesAsync();

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task GetLikeByIdAsync_ShouldReturnCorrectLike()
        {
            // Arrange
            var like = new Like { UserId = 1, ImageId = 1 };
            _context.Likes.Add(like);
            await _context.SaveChangesAsync();

            // Act
            var result = await _likeService.GetLikeByIdAsync(like.Id);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(like.UserId, result.UserId);
            ClassicAssert.AreEqual(like.ImageId, result.ImageId);
        }

        [Test]
        public async Task GetLikeByUserAsync_ShouldReturnLikesForUser()
        {
            // Arrange
            var like1 = new Like { UserId = 1, ImageId = 1 };
            var like2 = new Like { UserId = 1, ImageId = 2 };
            _context.Likes.AddRange(like1, like2);
            await _context.SaveChangesAsync();

            // Act
            var result = await _likeService.GetLikeByUserAsync(1);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(2, result.Count());
        }

        [Test]
        public async Task GetLikeByImageAsync_ShouldReturnLikesForImage()
        {
            // Arrange
            var like1 = new Like { UserId = 1, ImageId = 1 };
            var like2 = new Like { UserId = 2, ImageId = 1 };
            _context.Likes.AddRange(like1, like2);
            await _context.SaveChangesAsync();

            // Act
            var result = await _likeService.GetLikeByImageAsync(1);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(2, result.Count());
        }

        [Test]
        public async Task CreateLikeAsync_ShouldAddLikeAndReturnLike()
        {
            // Arrange
            var user = new User { Id = 1, FullName = "Test User", UserName = "testuser", Email = "test@example.com", Password = "password", Signature = "Prata" };
            var like = new Like { UserId = 1, ImageId = 1 };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Act
            var result = await _likeService.CreateLikeAsync(like);

            // Assert
            ClassicAssert.IsNotNull(result);
            ClassicAssert.AreEqual(like.UserId, result.UserId);
            ClassicAssert.AreEqual(like.ImageId, result.ImageId);

            var likesInDb = await _context.Likes.ToListAsync();
            ClassicAssert.AreEqual(1, likesInDb.Count);
            ClassicAssert.AreEqual(like.UserId, likesInDb[0].UserId);
            ClassicAssert.AreEqual(like.ImageId, likesInDb[0].ImageId);
        }
    }
}

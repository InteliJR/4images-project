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
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
        }
        
        private ApplicationDbContext CreateContext()
        {
            var context = new ApplicationDbContext(_options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            return context;
        }

        private LikeService CreateLikeService(ApplicationDbContext context)
        {
            return new LikeService(context);
        }

        [Fact]
        public async Task GetLikesAsync_ReturnAllLikes()
        {
            using (var context = CreateContext())
            {
                var likeService = CreateLikeService(context);

                var likes = new List<Like>
                {
                    new Like { UserId = 1, ImageId = 1 },
                    new Like { UserId = 2, ImageId = 1 }
                };

                context.Likes.AddRange(likes);
                await context.SaveChangesAsync();

                var result = await likeService.GetLikesAsync();

                Assert.Equal(2, result.Count());
            }
        }

        [Fact]
        public async Task CreateLikeAsync_CreatesLikeSuccessfully()
        {
            using (var context = CreateContext())
            {
                var likeService = CreateLikeService(context);

                var like = new Like { UserId = 1, ImageId = 1 };

                var result = await likeService.CreateLikeAsync(like);

                Assert.NotNull(result);
                Assert.Equal(1, result.UserId);
                Assert.Equal(1, result.ImageId);

                var likeFromDb = await context.Likes.FirstOrDefaultAsync(l => l.UserId == 1 && l.ImageId == 1);
                Assert.NotNull(likeFromDb);
            }
        }

    }
}

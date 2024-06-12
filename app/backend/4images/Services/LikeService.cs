using _4images.Data;
using _4images.Models;
using Microsoft.EntityFrameworkCore;

namespace _4images.Services
{
    public class LikeService
    {
        private readonly ApplicationDbContext _context;

        public LikeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Like>> GetLikesAsync()
        {
            return await _context.Likes.ToListAsync();
        }

        public async Task<Like> GetLikeByIdAsync(int id)
        {
            return await _context.Likes.FindAsync(id);
        }

        public async Task<IEnumerable<Like>> GetLikeByUserAsync(int userId)
        {
            var likes = await _context.Likes
                                        .Where(c => c.UserId == userId)
                                        .ToListAsync();
            return likes;
        }

        public async Task<IEnumerable<Like>> GetLikeByImageAsync(int imageId)
        {
            var likes = await _context.Likes
                                        .Where(c => c.ImageId == imageId)
                                        .ToListAsync();
            return likes;
        }

        public async Task<Like> CreateLikeAsync(Like like)
        {
            // Validar User
            var userId = await _context.Users.FindAsync(like.UserId);
            if (userId == null) return null;
            
            // Validar Image
            
            _context.Likes.Add(like);
            await _context.SaveChangesAsync();
            return like;
        }
    }
}

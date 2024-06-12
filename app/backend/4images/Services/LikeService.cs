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

        public async Task<IEnumerable<Curtida>> GetCurtidasAsync()
        {
            return await _context.Curtidas.ToListAsync();
        }

        public async Task<Curtida> GetCurtidaByIdAsync(int id)
        {
            return await _context.Curtidas.FindAsync(id);
        }

        public async Task<IEnumerable<Curtida>> GetCurtidaByUserAsync(int userId)
        {
            var curtidas = await _context.Curtidas
                                        .Where(c => c.UserId == userId)
                                        .ToListAsync();
            return curtidas;
        }

        public async Task<IEnumerable<Curtida>> GetCurtidaByImageAsync(int imageId)
        {
            var curtidas = await _context.Curtidas
                                        .Where(c => c.ImageId == imageId)
                                        .ToListAsync();
            return curtidas;
        }

        public async Task<Curtida> CreateCurtidaAsync(Curtida curtida)
        {
            // Validar User
            var userId = await _context.Users.FindAsync(curtida.UserId);
            if (userId == null) return null;
            
            // Validar Image
            
            _context.Curtidas.Add(curtida);
            await _context.SaveChangesAsync();
            return curtida;
        }
    }
}

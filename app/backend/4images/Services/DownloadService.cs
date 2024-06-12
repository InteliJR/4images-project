using System.Collections.Generic;
using System.Threading.Tasks;
using _4images.Data;
using _4images.Models;
using Microsoft.EntityFrameworkCore;

namespace _4images.Services
{
    public class DownloadService
    {
        private readonly ApplicationDbContext _context;

        public DownloadService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Download>> GetAllDownloadsAsync()
        {
            return await _context.Downloads
                .Include(d => d.FileFK)
                .Include(d => d.TransactionFK)
                .Include(d => d.SignatureFK)
                .ToListAsync();
        }
        public async Task<Download> GetDownloadByIdAsync(int id)
        {
            return await _context.Downloads
                .Include(d => d.FileFK)
                .Include(d => d.TransactionFK)
                .Include(d => d.SignatureFK)
                .FirstOrDefaultAsync(d => d.Id == id);
        }
        public async Task<Download> CreateDownloadAsync(Download download)
        {
            _context.Downloads.Add(download);
            await _context.SaveChangesAsync();
            return download;
        }
        public async Task<Download> UpdateDownloadAsync(Download download)
        {
            _context.Entry(download).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return download;
        }
        public async Task DeleteDownloadAsync(int id)
        {
            var download = await _context.Downloads.FindAsync(id);
            if (download != null)
            {
                _context.Downloads.Remove(download);
                await _context.SaveChangesAsync();
            }
        }
    }
}

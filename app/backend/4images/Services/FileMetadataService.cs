using _4images.Data;
using _4images.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace _4images.Services
{
    public class FileMetadataService : IFileMetadataService
    {
        private readonly ApplicationDbContext _context;

        public FileMetadataService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddFileMetadataAsync(FileMetadata metadata)
        {
            _context.FileMetadatas.Add(metadata);
            await _context.SaveChangesAsync();
        }

        public async Task<FileMetadata> GetFileMetadataAsync(int id)
        {
            return await _context.FileMetadatas.FindAsync(id);
        }

        public async Task<FileMetadata> GetFileMetadataByNameAsync(string fileName)
        {
            return await _context.FileMetadatas.SingleOrDefaultAsync(f => f.FileName == fileName);
        }

        public async Task UpdateFileMetadataAsync(FileMetadata metadata)
        {
            _context.FileMetadatas.Update(metadata);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFileMetadataAsync(int id)
        {
            var metadata = await _context.FileMetadatas.FindAsync(id);
            if (metadata != null)
            {
                _context.FileMetadatas.Remove(metadata);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteFileMetadataByNameAsync(string fileName)
        {
            var metadata = await _context.FileMetadatas.SingleOrDefaultAsync(f => f.FileName == fileName);
            if (metadata != null)
            {
                _context.FileMetadatas.Remove(metadata);
                await _context.SaveChangesAsync();
            }
        }
    }
}

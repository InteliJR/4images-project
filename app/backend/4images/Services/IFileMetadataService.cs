using _4images.Models;
using System.Threading.Tasks;

namespace _4images.Services
{
    public interface IFileMetadataService
    {
        Task AddFileMetadataAsync(FileMetadata metadata);
        Task<FileMetadata> GetFileMetadataAsync(int id);
        Task UpdateFileMetadataAsync(FileMetadata metadata);
        Task DeleteFileMetadataAsync(int id);
    }
}

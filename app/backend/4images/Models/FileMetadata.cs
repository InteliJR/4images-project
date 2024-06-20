using System.ComponentModel.DataAnnotations;

namespace _4images.Models
{
    public class FileMetadata
    {
        public int Id { get; set; }

        [Required]
        public string BlobUrl { get; set; }

        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long Size { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;

namespace _4images.Models
{
    public class Download
    {
        public int Id { get; set; }

        [Required]
        public int NumDownloads { get; set; }

        [Required]
        public int FileFK { get; set; }

        [ForeignKey("FileFK")]
        public virtual FileMetadata FileMetadata { get; set; }

        [Required]
        public int TransactionFK { get; set; }

        [ForeignKey("TransactionFK")]
        public virtual Transaction Transaction { get; set; }

        [Required]
        public int SignatureFK { get; set; }

        [ForeignKey("SignatureFK")]
        public virtual Signature Signature { get; set; }
    }
}

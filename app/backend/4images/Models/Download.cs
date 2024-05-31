using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4images.Models
{
    public class Download
    {
        public int Id { get; set; }

        [Required]
        public int NumDownloads { get; set; }

        [Required]
        public int FileFK { get; set; }

        // [ForeignKey("FileId")]
        // public virtual File File { get; set; }

        [Required]
        public int TransactionFK { get; set; }

        // [ForeignKey("TransactionId")]
        // public virtual Transaction Transaction { get; set; }

        [Required]
        public int SignatureFK { get; set; }

        // [ForeignKey("SubscriptionId")]
        // public virtual Subscription Subscription { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4images.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public string Filename { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; } // FK do usuário
    }
}

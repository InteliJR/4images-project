using System.ComponentModel.DataAnnotations;

namespace _4images.Models
{
    public enum SignatureType
    {
        cooper,
        silver,
        gold
    }
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; } // Hashed password

        [Required]
        public SignatureType Signature { get; set; }

        public string? GoogleId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genre
    {
        public byte Id { get; set; } /* byte is not nullable so it will be not null in db */

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
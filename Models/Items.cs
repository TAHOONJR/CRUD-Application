using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Price { get; set; }

        public string? Description { get; set; }

        [Required]
        [Display(Name = "Category")] //to display the name in the view
        public int? CategoryId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //to auto generate the date
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string? ImagePath { get; set; }

        [NotMapped] //to not add this to the database
        public IFormFile? clientFile { get; set; }
    }
}

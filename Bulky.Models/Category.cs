using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int intCategoryId { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public required string strCategoryName { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100.")]
        public int intDisplayOrder { get; set; }

    }
}

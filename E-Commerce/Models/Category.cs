using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("Movie Name")]
        [MaxLength(50)]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "DisplayOrder should be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string Id { get; }

        [Required]
        public string Content { get; }
    }
}
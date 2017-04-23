using NBShop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NBShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Alias { get; set; }

        public string Image { get; set; }

        public XElement MoreImage { get; set; }

        public decimal Price { get; set; }

        public decimal Promotion { get; set; }

        public int Waranty { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool HomeFlag { get; set; }

        public bool HotFlag { get; set; }

        public int ViewCout { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}
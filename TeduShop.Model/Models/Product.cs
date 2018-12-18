using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;
using System.Xml.Linq;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        public string Images { get; set; }
        public XElement MoreImaes { get; set; }
        public decimal Price { get; set; }
        public decimal? Promotion { get; set; }
        public int? Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; } 
        public int? ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public  virtual ProductCategory ProductCategory { get; set; }

        public virtual IEnumerable<OrderDetail> Orderdetails { get; set; }


    }
}

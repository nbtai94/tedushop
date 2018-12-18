using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }

        public string DisplayOrder { get; set; }
        [Required]
        [ForeignKey("GroupID")]
        public int GroupID { get; set; }
        public virtual MenuGroup MenuGroup { get; set; }
        public string Target { get; set; }
        public bool Status { get; set; }
    }
}

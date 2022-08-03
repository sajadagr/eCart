using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Category
    {
        [Key]
        [Required]
        public long ID { get; set; }
        public long MenuID { get; set; }
        [ForeignKey("MenuID")]
        [NotMapped]
        public virtual Menu Menus { get; set; }
        [StringLength(255)]
        public string CategoryName { get; set; }
        public int CategoryOrder { get; set; }

        [ForeignKey("CategoryID")]
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}

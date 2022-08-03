using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class SubCategory
    {
        [Key]
        [Required]
        public long ID { get; set; }
        public long CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        [NotMapped]
        public virtual Category Categories { get; set; }
        [StringLength(255)]
        public string SubcategoryName { get; set; }
        public int SubcategoryOrder { get; set; }
    }
}

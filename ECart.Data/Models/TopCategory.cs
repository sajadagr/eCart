using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class TopCategory
    {
        [Key]
        [Required]
        public long ID { get; set; }
        public long menuID { get; set; }
        public long CategoryID { get; set; }
        public long SubcategoryID { get; set; }
        [ForeignKey("SubcategoryID")]
        public SubCategory SubCategory { get; set; }
        public string ImagePath { get; set; }
        public string DisplayName { get; set; }
        public int DisplayOrder { get; set; }
    }
}

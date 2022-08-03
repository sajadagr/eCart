using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
   public class ProductImage
    {
        [Key]
        public long ID { get; set; }


        public long ProductID { get; set; }


        [ForeignKey("ProductID")]
        public Product Product { get; set; }


        [Column(TypeName = "varchar")]
        public string Color { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string ColorName { get; set; }


        public string ImagePath { get; set; }
    }
}

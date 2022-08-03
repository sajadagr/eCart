using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Product
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Specifications { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public string Keywords { get; set; }
        public bool IsActive { get; set; }
        public bool CODAvailable { get; set; }
        public bool OnlinePaymentAvailable { get; set; }
        public long? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
        public long? SubcategoryID { get; set; }
        [ForeignKey("SubcategoryID")]
        public virtual SubCategory SubCategory { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Barcode { get; set; }
    }
}

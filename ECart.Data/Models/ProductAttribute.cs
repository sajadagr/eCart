using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class ProductAttribute
    {
        [Key]
        public long ID { get; set; }
        public long? ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Color { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string ColorName { get; set; }
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Size { get; set; }
        public string Dimensions { get; set; }
        public string Weight { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public int Moq { get; set; }
        public int PhysicalStock { get; set; }
        public int ToBeDispatched { get; set; }
        public decimal NetWeight { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Balance
        {
            get
            {
                return (PhysicalStock - ToBeDispatched);
            }
            set
            {

            }
          
        }
        public DateTime AddedOn { get; set; }
       
        public DateTime ModifiedOn { get; set; }
       
    }
}

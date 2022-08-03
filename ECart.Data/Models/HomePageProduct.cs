using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class HomePageProduct
    {
        [Key]
        [Required]
        public long ID { get; set; }

        public int HeadingID { get; set; }
        [ForeignKey("Heading_ID")]
        public HomePageHeading HomePageHeading { get; set; }
        public long ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int ProductOrder { get; set; }
    }
}

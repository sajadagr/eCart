using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class ShippingPincode
    {
        [Key]
        public long ID { get; set; }
        [Column(TypeName = "varchar")]
        public string FromPincode { get; set; }
        [Column(TypeName = "varchar")]
        public string ToPinCode { get; set; }
        [ForeignKey("PincodeID")]
        public virtual ICollection<ShippingPincodeSlab> slabs { get; set; }
    }
}

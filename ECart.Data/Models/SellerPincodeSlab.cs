using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class SellerPincodeSlab
    {
        [Key]
        [Required]
        public long ID { get; set; }
        public long PincodeID { get; set; }
        [ForeignKey("PincodeID")]
        public SellerPincode SellerPincode { get; set; }
        public decimal FromWeight { get; set; }
        public decimal ToWeight { get; set; }
        public decimal ShippingCharges { get; set; }
        [StringLength(1000)]
        public string DeliveryTime { get; set; }
    }
}

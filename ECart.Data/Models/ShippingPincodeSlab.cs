using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class ShippingPincodeSlab
    {
        [Key]
        public long ID { get; set; }
        public long PincodeID { get; set; }
        [ForeignKey("Pincode_ID")]
        public ShippingPincode ShippingPincode { get; set; }
        public decimal ShippingCharges { get; set; }
        public decimal FromWeight { get; set; }
        public decimal ToWeight { get; set; }
        public string DeliveryTime { get; set; }
    }
}


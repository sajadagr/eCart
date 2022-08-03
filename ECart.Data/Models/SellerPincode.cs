using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class SellerPincode
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [StringLength(500)]
        public string Username { get; set; }
        [StringLength(10)]
        public string FromPincode { get; set; }
        [StringLength(10)]
        public string ToPincode { get; set; }
        public decimal NetWeight { get; set; }
    }
}

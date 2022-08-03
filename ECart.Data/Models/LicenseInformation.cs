using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class LicenseInformation
    {
        [Key]
        public long ID { get; set; }
        public string Username { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Amount { get; set; }
    }
}

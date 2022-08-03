using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class SellerFollower
    {
        [Key]
        [Required]
        public long ID { get; set; }
        public string Username { get; set; }
        public string SellerUsername { get; set; }
    }
}

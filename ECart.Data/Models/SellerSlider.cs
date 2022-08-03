using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class SellerSlider
    {
        [Key]
        [Required]
        public long ID { get; set; }
        public string Username { get; set; }
        public string ImagePath { get; set; }
        public string MobileImagePath { get; set; }
        public string TabImagePath { get; set; }
        public long DisplayOrder { get; set; }
        public string RouterLink { get; set; }
    }
}

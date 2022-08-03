using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Slider
    {
        [Key]
        [Required]
        public long ID { get; set; }
        public string ImagePath { get; set; }
        public string MobileImagePath { get; set; }
        public string TabImagePath { get; set; }
        public int DisplayOrder { get; set; }
        public string BigLabel { get; set; }
        public string SmallLabel { get; set; }
    }
}

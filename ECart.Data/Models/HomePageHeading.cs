using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class HomePageHeading
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string HeadingName { get; set; }
        public int HeadingOrder { get; set; }

        [ForeignKey("HeadingID")]
        public ICollection<HomePageProduct> HomePageProducts { get; set; }
    }
}

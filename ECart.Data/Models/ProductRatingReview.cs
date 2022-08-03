using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class ProductRatingReview
    {
        public long ID { get; set; }
        public string Mobile { get; set; }
        [ForeignKey("Mobile")]
        public User User { get; set; }
        public long ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public decimal Rating { get; set; }
        public string Review { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}

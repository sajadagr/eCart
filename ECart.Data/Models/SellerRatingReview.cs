using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class SellerRatingReview
    {
        [Key]
        public long ID { get; set; }
        public string Username { get; set; }
        [ForeignKey("Username")]
        public User User { get; set; }
        public string SellerUsername { get; set; }
        [ForeignKey("SellerUsername")]
        public User Seller { get; set; }
        public decimal Rating { get; set; }
        public string Review { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}

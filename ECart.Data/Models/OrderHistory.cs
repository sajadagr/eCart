using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class OrderHistory
    {
        [Key]
        public long ID { get; set; }
        public long OrderID { get; set; }
        [ForeignKey("Order_ID")]
        public virtual Order Order { get; set; }
        public DateTime DateModified { get; set; }
        public string Comments { get; set; }
    }
}

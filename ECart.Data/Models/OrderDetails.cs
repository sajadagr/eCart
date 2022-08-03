using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class OrderDetails
    {
        [Key]
        public long ID { get; set; }
        public long OrderID { get; set; }
        [ForeignKey("Order_ID")]
        public virtual Order Order { get; set; }
        public long ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        public string ProductName { get; set; }
        public string Specifications { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Total { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public string PinCode { get; set; }
        public decimal NetWeight { get; set; }
        public decimal TotalNetWeight { get; set; }
    }
}

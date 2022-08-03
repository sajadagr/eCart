using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Order
    {
        [Key]
        public long ID { get; set; }
        public string Username { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerState { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerAddress { get; set; }
        public string PinCode { get; set; }
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal ShippingCharges { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        [ForeignKey("OrderID")]
        public ICollection<OrderDetails> OrderDetails { get; set; }

        [ForeignKey("OrderID")]
        public ICollection<OrderHistory> OrderHistories { get; set; }
    }
}

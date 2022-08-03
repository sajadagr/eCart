using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class OrderMasterObject
    {
        public Order Order { get; set; }
        public List<OrderDetails> OrderItems { get; set; }
        public OrderHistory OrderHistory { get; set; }
    }
}

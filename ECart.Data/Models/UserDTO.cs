using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class UserDTO
    {
        public User User { get; set; }
        public string Otp { get; set; }
        public string SessionID { get; set; }
    }
}

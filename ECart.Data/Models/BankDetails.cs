using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class BankDetails
    {
        [Key]
        public long ID { get; set; }

        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string IfscCode { get; set; }
        public string Username { get; set; }

        [ForeignKey("Username")]
        public User User { get; set; }

    }
}

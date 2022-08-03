using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Address
    {
        [Key]
        public long ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public long CountryID { get; set; }
        public long StateID { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public bool IsDefault { get; set; }
        public string StreetAddress { get; set; }
    }
}

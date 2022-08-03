using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class User
    {
        [Required]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Key]
        [Required]
        [StringLength(20)]
        public string Mobile { get; set; }
        [StringLength(10)]
        public string PinCode { get; set; }
        public long CountryID { get; set; }
        public long StateID { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        public DateTime? AddedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}

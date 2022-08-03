using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Country
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [StringLength(3)]
        public string SortName { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(20)]
        public string PhoneCode { get; set; }
    }
}

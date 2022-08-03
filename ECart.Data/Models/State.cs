using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class State
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public long CountryID { get; set; }
        [ForeignKey("CountryID")]
        public Country Country { get; set; }
    }
}

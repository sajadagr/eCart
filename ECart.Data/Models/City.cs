using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class City
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public long StateID { get; set; }
        [ForeignKey("StateID")]
        public State State { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Menu
    {
        [Required]
        [Key]
        public long ID { get; set; }
        [StringLength(255)]
        public string MenuName { get; set; }
        public int MenuOrder { get; set; }

        [ForeignKey("MenuID")]
        public ICollection<Category> Categories { get; set; }
    }
}

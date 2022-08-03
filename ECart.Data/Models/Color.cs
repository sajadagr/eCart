using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Color
    {
        [Key]
        public long ID { get; set; }
        public string ColorName { get; set; }
        public string ColorValue { get; set; }
    }
}

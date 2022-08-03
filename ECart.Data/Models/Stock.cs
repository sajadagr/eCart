using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Stock
    {
        [Key]
        [Required]
        public long ID { get; set; }
        public long ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Brand { get; set; }
        public int PhysicalStock { get; set; }
        public int ToBeDispatched { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Balance
        {
            get
            {
                return PhysicalStock - ToBeDispatched;
            }
            set
            {
            }
        }

        public DateTime? AddedOn
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
            }
        }

        public string AddedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}

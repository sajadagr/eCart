using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class Banner
    {
        public long ID { get; set; }
        public int BannerNo { get; set; }
        public string ImagePath { get; set; }
        public string RouterLink { get; set; }
        public string BigText { get; set; }
        public string SmallText { get; set; }
    }
}

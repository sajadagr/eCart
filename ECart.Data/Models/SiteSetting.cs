using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Data.Models
{
    public class SiteSetting
    {
        [Key]
        public int ID { get; set; }
        public string HeaderContactNo { get; set; }
        public string LogoPath { get; set; }
        public string SiteName { get; set; }
        public string Address { get; set; }
        public string MapHtml { get; set; }
        public string PhoneNos { get; set; }
        public string Emails { get; set; }
        public string About { get; set; }
        public string AboutUs { get; set; }
        public string CancellationRefundPolicy { get; set; }
        public string PrivacyPolicy { get; set; }
        public string Pricing { get; set; }
        public string Terms { get; set; }
    }
}

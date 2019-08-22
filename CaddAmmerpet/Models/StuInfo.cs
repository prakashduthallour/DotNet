using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CaddAmmerpet.Models
{
    public class StuInfo
    {
        [Display(Name ="Name",Order =1)]
        public string NameLabel { get; set; }

        public string StuName { get; set; }
        [Display(Name = "Mobile", Order = 1)]
        public string MobileLabel { get; set; }

        public string Mobile { get; set; }


    }
}
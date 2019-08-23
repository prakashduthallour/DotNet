using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Google.Apis.Drive.v3.Data;
namespace CaddAmmerpet.Models
{
    public class StuInfo
    {
        CaddAmmerpet.GoogleApi.DataRetrival obj = new CaddAmmerpet.GoogleApi.DataRetrival();

        [Display(Name ="Name",Order =1)]
        public string NameLabel { get; set; }

        public string StuName { get; set; }
        [Display(Name = "Mobile", Order = 1)]
        public string MobileLabel { get; set; }

        public string Mobile { get; set; }
        public IList<Google.Apis.Drive.v3.Data.File>  DataFlow()
        {
            return obj.FilesList();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaddAmmerpet.Models;


namespace CaddAmmerpet.Controllers
{
    public class HomeController : Controller
    {
      //  StuInfo info = new StuInfo();
        public ActionResult Index()
        {
         
            return View();
        }
        public ActionResult Walkin()
        {
            List<Dictionary<string, object>> walkinlist = new List<Dictionary<string, object>>();
           
             
            return View();
        }
       
    }
}
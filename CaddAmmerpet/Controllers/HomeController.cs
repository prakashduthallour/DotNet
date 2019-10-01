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
       public ActionResult Index()
        {
         
            return View();
        }
        public ActionResult Walkin()
        {
           return View();
        }
       
    }
}
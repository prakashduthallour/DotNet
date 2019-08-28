using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaddAmmerpet.Models;
using CaddAmmerpet.API_Configuration.LocalDB;

namespace CaddAmmerpet.Controllers
{
    public class HomeController : Controller
    {
      //  StuInfo info = new StuInfo();
        public ActionResult Index()
        {
            LocalDBConnection dbCon = new LocalDBConnection();
            dbCon.InsertData();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Sample_View()
        {
            return View();
        }
    }
}
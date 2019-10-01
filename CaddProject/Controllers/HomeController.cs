
using CaddProject.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CaddProject.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
           return View();
        }
        public ActionResult GetWalkin()
        {
            WalkinContext cntx = new WalkinContext();
            Walkin walkin = new Walkin();
            IQueryable<Walkin> listitem = cntx.Walkins;
         var list =from temp in cntx.Walkins select  temp ;
            walkin.walkinList = list.ToList();
                return View(walkin);
        }
        [HttpPost]
        public ActionResult GetWalkin(Walkin walkin)
        {

           
            return View();
        }
    }
}
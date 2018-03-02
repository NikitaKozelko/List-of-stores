using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private StoresContext db = new StoresContext();
        
        public ActionResult Index()
        {
            IEnumerable<Store> stores = db.Stores;
            ViewBag.Stores = stores;
            return View();
        }

        public ActionResult ViewProducts(int id)
        {
            Store store = db.Stores.SingleOrDefault(a => a.Id == id);
            ViewBag.Store = store;
            return PartialView();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
    
}
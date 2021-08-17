using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace eCommerce.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage

        ETRADE4Entities db = new ETRADE4Entities();
        public ActionResult Index()
        {
            ViewModel model = new ViewModel();

             model.ItemList = db.items.ToList();
             model.CategoryList = db.category1.ToList();

            return View(model);
        }
    }
}
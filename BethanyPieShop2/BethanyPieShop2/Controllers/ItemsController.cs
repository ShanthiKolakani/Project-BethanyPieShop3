using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BethanyPieShop2.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
      
        public ActionResult Index1()
        {
           
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
        public ActionResult Details() 
        {
            return View();
        }
    }
}
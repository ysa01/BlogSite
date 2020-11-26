using BlogSite.Bussiness.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
           
            return View(contentrepository.IndexView());
        }
        // Hakkımızda
        public ActionResult About()
        {
            return View();
        }
        //servis
        public ActionResult Categories()
        {
            return View();
        }
        //iletişim
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult DevaminiOku(int id)
        {
            return View(contentrepository.DevaminiOku(id));
        }
    }
}
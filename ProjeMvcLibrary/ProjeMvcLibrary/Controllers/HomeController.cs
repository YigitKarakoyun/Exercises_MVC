using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeMvcLibrary.Models.Entity;
namespace ProjeMvcLibrary.Controllers
{
    public class HomeController : Controller
    {
        DbMvcKutuphaneEntities2 db = new DbMvcKutuphaneEntities2();

        [HttpGet]
        public ActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMember(TBL_LIBRARY p)
        {
            db.TBL_LIBRARY.Add(p);
            db.SaveChanges();

            return View();
        }
    }
}
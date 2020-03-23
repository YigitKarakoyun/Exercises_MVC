using ProjeMvcKisiselBlog.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeMvcKisiselBlog.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Default1
        DbMvcKisiselBlogEntities db = new DbMvcKisiselBlogEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(TBL_MESSAGE p)
        {
            db.TBL_MESSAGE.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
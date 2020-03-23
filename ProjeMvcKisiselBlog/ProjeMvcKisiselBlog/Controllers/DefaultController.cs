using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeMvcKisiselBlog.Models.Entity;
using ProjeMvcKisiselBlog.Models.Class;
namespace ProjeMvcKisiselBlog.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMvcKisiselBlogEntities db = new DbMvcKisiselBlogEntities();
        public ActionResult Index()
        {
            CollectionClass cs = new CollectionClass();
            cs.tbl_HAKKIMDA = db.TBL_HAKKIMDA.ToList();
            cs.tbl_ILETISIM = db.TBL_ILETISIM.ToList();
            cs.tbl_MESAJ = db.TBL_MESSAGE.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult SendMessage()
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
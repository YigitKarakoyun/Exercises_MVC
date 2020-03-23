using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeMvcOrganikBesinler.Models.Entity;

namespace ProjeMvcOrganikBesinler.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMvcTarimEntities1 db = new DbMvcTarimEntities1();
        public ActionResult Index()
        {
            var values = db.TBL_URUNLER.Take(1).ToList();
            return View(values);
        }
        //public ActionResult Index(int id)
        //{
        //    var values = db.TBL_URUNLER.ToList().Take(id);
        //    return View(values);
        //}
    }
}
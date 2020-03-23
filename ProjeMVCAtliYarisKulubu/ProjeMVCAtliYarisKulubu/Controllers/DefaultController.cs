using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeMVCAtliYarisKulubu.Models.Entity;
namespace ProjeMVCAtliYarisKulubu.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMvcAtYarisiEntities db = new DbMvcAtYarisiEntities();
        public ActionResult Index()
        {
            var temp = db.TBL_BILGI.ToList();
            return View(temp);
        }
    }
}
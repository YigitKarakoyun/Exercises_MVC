using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeMvcDropDownList.Models.Entity;
namespace ProjeMvcDropDownList.Controllers
{
    public class HomeController : Controller
    {
        DbMvcCityEntities db = new DbMvcCityEntities();
        public ActionResult Index()
        {
            return View(db.TBL_CITY.ToList());
        }


    }
}
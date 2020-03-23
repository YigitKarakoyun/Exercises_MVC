using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeRegisterForm.Models.Entity;
namespace ProjeRegisterForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        DbMvcRegisterFormEntities db = new DbMvcRegisterFormEntities();
        public ActionResult AddStudent(TBL_STUDENT p)
        {
            db.TBL_STUDENT.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
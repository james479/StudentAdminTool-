using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ScheduleAdminTool.DATA.EF;

namespace ScheduleAdminTool.Controllers
{
    public class HomeController : Controller
    {
        private StudentAdminToolEntities db = new StudentAdminToolEntities();

        [HttpGet]
        public ActionResult Index()
        {
            var students = db.Students.Include(s => s.StudentStatus);
            return View(students.ToList());
        }

        [HttpGet]
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

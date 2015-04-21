using MVC5RepositoryProject.DAL;
using MVC5RepositoryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5RepositoryProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
         private SchoolContext db = new SchoolContext();
        
        public ActionResult Index()
        {
             return View();
        }
             
        public ActionResult About()
        {
            //var query = "SELECT EnrollmentDate, COUNT(*) AS StudentCount "
            //   + "FROM Person "
            //   + "WHERE EnrollmentDate IS NOT NULL "
            //   + "GROUP BY EnrollmentDate";
            //var data = db.Database.SqlQuery<EnrollmentDateGroup>(query);
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
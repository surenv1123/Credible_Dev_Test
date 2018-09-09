using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Credible_Dev_Test.Services;
using Credible_Dev_Test.Models;

namespace Credible_Dev_Test.Controllers
{
    public class u_course_portalController : Controller
    {
       

        // GET: u_course_portal/Details/5
        public ActionResult Details(int id)
        {
            CourseServices courseServices = new CourseServices();
            List<u_course_portal> CoursesRespList=courseServices.GetCoursesByPortalID(id);
            return PartialView("courseview",CoursesRespList);
        }

       
    }
}

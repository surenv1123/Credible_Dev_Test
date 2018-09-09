using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Credible_Dev_Test.Services;
using Credible_Dev_Test.Models;


namespace Credible_Dev_Test.Controllers
{
    public class u_registrationController : Controller
    {
       

        // GET: u_registration/Details/5
        public ActionResult Details(int id)
        {
            RegistrationService rs = new RegistrationService();
            List<RegisteredUserInfo> registeredUsers = rs.GetRegistrationByCourseID(id);

            return PartialView("userview",registeredUsers);
        }
    

       
    }
}

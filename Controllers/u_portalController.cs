using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Credible_Dev_Test.Models;

namespace Credible_Dev_Test.Controllers
{
    public class u_portalController : Controller
    {
        private dev_testEntities db = new dev_testEntities();

        // GET: u_portal
        public ActionResult Index()
        {
            return View(db.u_portal.ToList());
        }

       
        
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

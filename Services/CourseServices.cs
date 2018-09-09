using Credible_Dev_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Credible_Dev_Test.Services
{
    public class CourseServices
    {

        public List<u_course_portal> GetCoursesByPortalID(int portal_id) 

        {
            var query= new List<u_course_portal>();
            try
            {
                dev_testEntities db = new dev_testEntities();

                query =(List<u_course_portal>)(from s in db.u_course_portal where s.portal_id == portal_id orderby s.course_portal_nm select s).ToList();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception occurred" + e.Message);
                throw new System.InvalidOperationException("database exception");

            }

            //select cp.course_portal_id, cp.course_portal_nm
            //from    u_course_portal cp
            //where cp.portal_id = 1-- will show only courses for specific client
            //orderby cp.course_portal_nm


            return query;
        }

    }
}
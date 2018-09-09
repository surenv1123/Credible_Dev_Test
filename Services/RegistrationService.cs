using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Credible_Dev_Test.Models;


namespace Credible_Dev_Test.Services
{
    public class RegistrationService
    {
        public List<RegisteredUserInfo> GetRegistrationByCourseID(int course_portal_id)
        {
            var query = new List<RegisteredUserInfo>();
            try
            {
                dev_testEntities dbContext = new dev_testEntities();
                //query = (from s in dbContext.u_registration where s.course_portal_id == course_portal_id orderby s.registration_id select s).ToList();

                // select u.user_id, u.first_nm, u.last_nm,r.registration_dttm from u_registration as r innerjoin u_user as u on r.userid == u.userid where r.course_portal_id = course_portal_id ;

                var requery = from r in dbContext.u_registration join u in dbContext.u_user on r.user_id equals u.user_id where r.course_portal_id == course_portal_id select new { u.user_id, u.first_nm, u.last_nm, r.registration_dttm };
                //query = (from r in dbContext.u_registration join u in dbContext.u_user on r.user_id equals u.user_id where r.course_portal_id == course_portal_id select new RegisteredUserInfo ( u.user_id, u.first_nm, u.last_nm,r.registration_dttm)).ToList();
                foreach (var item in requery)
                {

                    query.Add(new RegisteredUserInfo(item.user_id,item.first_nm,item.last_nm,item.registration_dttm));

                  //  Console.WriteLine("test" + item.user_id);
                }
            }
            catch (Exception e)
            {

                throw new Exception("test");

            }
            return query;

        }

    }

   
}
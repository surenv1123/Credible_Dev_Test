using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Credible_Dev_Test.Models
{
    public partial class RegisteredUserInfo
    {

        public RegisteredUserInfo()
        {

        }

        public RegisteredUserInfo(int user_id,string first_nm,string last_nm,DateTime registration_dttm)
        {
            this.user_id = user_id;
            this.first_nm = first_nm;
            this.last_nm = last_nm;
            this.registration_dttm = registration_dttm;

        }
        public int user_id { get; set; }
        public string first_nm { get; set; }
        public string last_nm { get; set; }
        public System.DateTime registration_dttm { get; set; }
    }
}
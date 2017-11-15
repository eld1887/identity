using Identity.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Dapper.Samples.Web.Entities
{
    public class CustomUser : DapperIdentityUser
    {
        public string FirstName { get; set; }

        public CustomUser() { }
        public CustomUser(string userName) : base(userName) { }
    }
}

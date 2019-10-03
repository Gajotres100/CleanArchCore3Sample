using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Users.AddUser
{
    public class AddUserModel
    {
        public class AddUserData
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string UserId { get; set; }
            public string ContactInfo { get; set; }
        }

        [FromBody] public AddUserData Data { get; set; }
        [FromRoute(Name = "tenantId")] public Guid TenantID { get; set; }
    }
}

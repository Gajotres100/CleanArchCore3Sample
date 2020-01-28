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
            [FromBody] public string FirstName { get; set; }
            [FromBody] public string LastName { get; set; }
            [FromBody] public string Username { get; set; }
            [FromBody] public string Email { get; set; }
            [FromBody] public string UserId { get; set; }
            [FromBody] public string ContactInfo { get; set; }
            [FromBody] public string TransactionId { get; set; }
        }

        [FromBody] public AddUserData Data { get; set; }
        [FromRoute(Name = "tenantId")] public Guid TenantID { get; set; }
    }
}

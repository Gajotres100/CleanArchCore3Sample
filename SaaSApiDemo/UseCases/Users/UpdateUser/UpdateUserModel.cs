using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Users.UpdateUser
{
    public class UpdateUserModel
    {
        public class UpdateUserData
        {
            [FromBody] public string FirstName { get; set; }
            [FromBody] public string LastName { get; set; }
            [FromBody] public string Email { get; set; }
            [FromBody] public string ContactInfo { get; set; }
            [FromBody] public string TransactionId { get; set; }
        }

        [FromBody] public UpdateUserData Data { get; set; }
        [FromRoute(Name = "tenantId")] public Guid TenantId { get; set; }
        [FromRoute(Name = "userId")] public Guid UserId { get; set; }
    }
}

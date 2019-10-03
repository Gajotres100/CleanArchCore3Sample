using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Tenants.UpdateTenant
{
    public class UpdateTenantModel
    {
        public class BodyData
        {            
            [FromBody] public string CompanyName { get; set; }
            [FromBody] public string Address { get; set; }
            [FromBody] public string FirstName { get; set; }
            [FromBody] public string LastName { get; set; }
            [FromBody] public string Email { get; set; }
            [FromBody] public string TransactionId { get; set; }
        }

        [FromBody] public BodyData Data { get; set; }
        [FromRoute(Name = "tenantId")] public Guid TenantID { get; set; }
    }
}

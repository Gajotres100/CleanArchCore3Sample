using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UserCases.Tenants.Commands
{
    public class AddTenantModel
    {
        public class AddTenantData
        {
            [FromBody] public string CompanyId { get; set; }
            [FromBody] public string CompanyName { get; set; }
            [FromBody] public string Address { get; set; }
            [FromBody] public string FirstName { get; set; }
            [FromBody] public string LastName { get; set; }
            [FromBody] public string Email { get; set; }
            [FromBody] public string TransactionId { get; set; }
        }

        [FromBody] public AddTenantData Data { get; set; }
    }
}

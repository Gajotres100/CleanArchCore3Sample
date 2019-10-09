using Akka.Actor;
using Application.UserCases.Tenants;
using Application.UserCases.Tenants.Commands;
using Microsoft.AspNetCore.Mvc;
using SaaSApiDemo.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Tenants.AddTenant
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TenantsController : ControllerBase
    {
        private readonly IActorRef _tenantManagerActor;

        public TenantsController(TenantActorProvider tenantManagerActorProvider)
        {
            _tenantManagerActor = tenantManagerActorProvider();
        }

        [HttpPost()]
        [Route("")]
        public async Task<IActionResult> PostAsync([FromRoute]AddTenantModel data)
        {
            _tenantManagerActor.Tell(data);
            return Accepted();
        }
        
    }
}

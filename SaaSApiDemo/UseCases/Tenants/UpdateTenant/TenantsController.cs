using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Tenants.UpdateTenant
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TenantsController : ControllerBase
    {
        [HttpPut()]
        [Route("{tenantId:guid}")]
        public async Task<IActionResult> PutAsync([FromRoute]UpdateTenantModel data) => Ok(data);
    }
}

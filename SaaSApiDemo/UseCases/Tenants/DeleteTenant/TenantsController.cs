using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Tenants.DeleteTenant
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TenantsController : ControllerBase
    {
        [HttpDelete()]
        [Route("{tenantId:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]Guid tenantId) => Ok(tenantId);
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Tenants.GetTenant
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TenantsController : ControllerBase
    {
        [HttpGet()]
        [Route("{tenantId:guid}")]
        public async Task<IActionResult> GetAsync([FromRoute]Guid tenantId) => Ok(tenantId);
    }
}

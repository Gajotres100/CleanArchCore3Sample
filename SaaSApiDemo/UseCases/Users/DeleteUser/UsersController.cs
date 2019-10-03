using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Users.DeleteUser
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Tenants/{tenantId}/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpDelete()]
        [Route("{tenantId:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]Guid tenantId) => Ok(tenantId);
    }
}

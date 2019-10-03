using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Users.UpdateUser
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Tenants/{tenantId}/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpPut()]
        [Route("{userId:guid}")]
        public async Task<IActionResult> GetAsync([FromRoute]UpdateUserModel data) => Ok(data);
    }
}

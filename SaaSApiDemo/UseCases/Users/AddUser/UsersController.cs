using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Users.AddUser
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Tenants/{tenantId}/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpPost()]
        [Route("")]
        public async Task<IActionResult> PostAsync([FromRoute]AddUserModel data) => Ok(data);
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Assets.AddAsset
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Tenants/{tenantId}/[controller]")]
    public class AssetsController : ControllerBase
    {
        [HttpPost()]
        [Route("")]
        public async Task<IActionResult> PostAsync([FromRoute]AddAssetModel data) => Ok(data);
    }
}

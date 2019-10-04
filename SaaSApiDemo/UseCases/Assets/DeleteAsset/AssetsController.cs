using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Assets.DeleteAsset
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Tenants/{tenantId}/[controller]")]
    public class AssetsController : ControllerBase
    {
        [HttpDelete()]
        [Route("{assetId:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]Guid assetId) => Ok(assetId);
    }
}

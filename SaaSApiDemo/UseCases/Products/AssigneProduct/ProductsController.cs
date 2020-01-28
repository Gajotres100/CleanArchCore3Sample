using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Products.AssigneProduct
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Tenants/{tenantId}/Users/{userId}/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpPost()]
        [Route("{productId:guid}")]
        public async Task<IActionResult> PostAsync([FromRoute]AssigneProductModel data) => Ok(data);
    }
}

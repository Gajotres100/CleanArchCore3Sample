using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Products.RemoveProduct
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/Tenants/{tenantId}/Users/{userId}/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpDelete()]
        [Route("{productId:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]DeleteProductModel data) => Ok(data);
    }
}

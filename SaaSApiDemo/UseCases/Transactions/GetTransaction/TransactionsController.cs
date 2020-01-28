using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Transactions.GetTransaction
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TransactionsController : ControllerBase
    {
        [HttpGet()]
        [Route("{transactionId:guid}")]
        public async Task<IActionResult> GetAsync([FromRoute]Guid transactionId) => Ok(transactionId);
    }
}

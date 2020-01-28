using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Products.RemoveProduct
{
    public class DeleteProductModel
    {
        public class AdditionalAttributes
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class RemoveProductData
        {
            [FromBody] public List<AdditionalAttributes> AdditionalAttribute { get; set; }
            [FromBody] public string TransactionId { get; set; }
        }

        [FromBody] public RemoveProductData Data { get; set; }
        [FromRoute(Name = "tenantId")] public Guid TenantId { get; set; }
        [FromRoute(Name = "userId")] public Guid UserId { get; set; }
        [FromRoute(Name = "productId")] public Guid ProductId { get; set; }
    }
}

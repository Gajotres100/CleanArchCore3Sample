using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaaSApiDemo.UseCases.Assets.UpdateAsset
{
    public class UpdateAssetModel
    {
        public class AdditionalAttributes
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class UpdateAssetData
        {            
            [FromBody] public int Quantity { get; set; }
            [FromBody] public string ProductId { get; set; }
            [FromBody] public List<AdditionalAttributes> AdditionalAttribute { get; set; }
            [FromBody] public string TransactionId { get; set; }
        }

        [FromBody] public UpdateAssetData Data { get; set; }
        [FromRoute(Name = "tenantId")] public Guid TenantID { get; set; }
        [FromRoute(Name = "assetId")] public Guid AssetId { get; set; }
    }
}

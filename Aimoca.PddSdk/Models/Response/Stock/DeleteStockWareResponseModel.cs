using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Response.Stock
{
    public partial class DeleteStockWareResponseModel : PddResponseModel
    {
        /// <summary>
        /// 操作成功：true
        /// </summary>
        [JsonProperty("open_api_response")]
        public bool? OpenApiResponse { get; set; }

    }

}

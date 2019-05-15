using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Request.Order
{
    public partial class GetOrderInformationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}

using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Response.Open
{
    public partial class MsgOpenMsgServiceSendBatchResponseModel : PddResponseModel
    {
        /// <summary>
        /// 回执id
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }
        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("code")]
        public int? Code { get; set; }
        /// <summary>
        /// 状态原因
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// 请求Id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

    }

}

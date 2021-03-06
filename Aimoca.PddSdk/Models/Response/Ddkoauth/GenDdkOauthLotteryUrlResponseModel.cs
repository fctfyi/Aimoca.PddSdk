using Newtonsoft.Json;
namespace Aimoca.PddSdk.Models.Response.Ddkoauth
{
    public partial class GenDdkOauthLotteryUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// lottery_url_response
        /// </summary>
        [JsonProperty("lottery_url_response")]
        public LotteryUrlResponseResponseModel LotteryUrlResponse { get; set; }
        public partial class LotteryUrlResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 返回总数
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }

        }

    }

}

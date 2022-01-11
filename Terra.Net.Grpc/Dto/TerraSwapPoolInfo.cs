using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terra.Net.Grpc.Converters;

namespace Terra.Net.Grpc.Dto
{
    public partial class TerraSwapPoolInfo
    {
        [JsonProperty("assets")]
        public List<Asset> Assets { get; set; }
        public decimal Price => Assets.Count != 2 ? -1 : (decimal)Assets[0].Amount / (decimal)Assets[1].Amount;

        [JsonProperty("total_share")]
        public ulong TotalShare { get; set; }

    }

    public partial class Asset
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("amount")]
        [JsonConverter(typeof(ParseUlongToStringConverter))]
        public ulong Amount { get; set; }


    }

    public partial class Info
    {
        [JsonProperty("native_token", NullValueHandling = NullValueHandling.Ignore)]
        public NativeToken NativeToken { get; set; }

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public Token Token { get; set; }
    }

    public partial class NativeToken
    {
        [JsonProperty("denom")]
        public string Denom { get; set; }
    }

    public partial class Token
    {
        [JsonProperty("contract_addr")]
        public string ContractAddress { get; set; }
    }

}

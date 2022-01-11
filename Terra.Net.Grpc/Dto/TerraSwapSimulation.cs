using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terra.Net.Grpc.Converters;

namespace Terra.Net.Grpc.Dto
{
    public class SwapSimulationResult
    {
        public ulong return_amount { get; set; }
        public ulong spread_amount { get; set; }
        public ulong commission_amount { get; set; }
    }
    public partial class TerraSwapSimulation
    {


        [JsonProperty("simulation")]
        public Simulation Simulation { get; set; }
        public static TerraSwapSimulation FromNativeToken(string denom, ulong amount)
        {
            var s = new TerraSwapSimulation()
            {
                Simulation = new Simulation()
                {
                    OfferAsset = new OfferAsset() { Amount = amount, Info = new Info() { NativeToken = new NativeToken() { Denom = denom } } }
                }
            };

            return s;
        }
        public static TerraSwapSimulation FromToken(string tokecnContractAddress, ulong amount)
        {
            var s = new TerraSwapSimulation()
            {
                Simulation = new Simulation()
                {
                    OfferAsset = new OfferAsset() { Amount = amount, Info = new Info() { Token = new Token() { ContractAddress = tokecnContractAddress } } }
                }
            };

            return s;
        }

    }

    public partial class Simulation
    {
        [JsonProperty("offer_asset")]
        public OfferAsset OfferAsset { get; set; }

    }

    public partial class OfferAsset
    {
        [JsonProperty("amount")]
        [JsonConverter(typeof(ParseUlongToStringConverter))]
        public ulong Amount { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }


}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.Dto
{
   
    public class TerraTokenBalance
    {
        [JsonProperty("balance")]
        public string Balance { get; set; }
    }
   
}

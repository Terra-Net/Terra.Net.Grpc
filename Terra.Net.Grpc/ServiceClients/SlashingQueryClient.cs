using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{    
    public partial class SlashingQueryClient : Cosmos.Slashing.V1Beta1.Query.QueryClient
    {       
        public SlashingQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public SlashingQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

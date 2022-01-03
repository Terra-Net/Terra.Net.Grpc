using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class FeegrantQueryClient : Cosmos.Feegrant.V1Beta1.Query.QueryClient
    {       
        public FeegrantQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public FeegrantQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

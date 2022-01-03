using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class DistributionQueryClient : Cosmos.Distribution.V1Beta1.Query.QueryClient
    {       
        public DistributionQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public DistributionQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

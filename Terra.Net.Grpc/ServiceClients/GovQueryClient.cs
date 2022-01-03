using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class GovQueryClient : Cosmos.Gov.V1Beta1.Query.QueryClient
    {       
        public GovQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public GovQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

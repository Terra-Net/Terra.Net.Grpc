using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class EvidenceQueryClient : Cosmos.Evidence.V1Beta1.Query.QueryClient
    {       
        public EvidenceQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public EvidenceQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

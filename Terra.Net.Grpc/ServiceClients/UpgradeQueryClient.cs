using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class UpgradeQueryClient : Cosmos.Upgrade.V1Beta1.Query.QueryClient
    {       
        public UpgradeQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public UpgradeQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

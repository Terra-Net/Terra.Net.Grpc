using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
   
    public partial class BlocksQueryClient : Cosmos.Base.Tendermint.V1Beta1.Service.ServiceClient
    {
        public BlocksQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {      
        }
        public BlocksQueryClient(GrpcChannel channel) : base(channel)
        {

        }
    }
}

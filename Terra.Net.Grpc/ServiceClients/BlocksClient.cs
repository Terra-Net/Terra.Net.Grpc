using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
   
    public class BlocksClient : Cosmos.Base.Tendermint.V1Beta1.Service.ServiceClient
    {
        public BlocksClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {      
        }
        public BlocksClient(GrpcChannel channel) : base(channel)
        {

        }
    }
}

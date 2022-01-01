using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public class AuthZTxClient : Cosmos.Authz.V1Beta1.Msg.MsgClient
    {
        public AuthZTxClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public AuthZTxClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

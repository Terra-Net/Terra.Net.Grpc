using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class GovMsgClient : Cosmos.Gov.V1Beta1.Msg.MsgClient
    {       
        public GovMsgClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public GovMsgClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

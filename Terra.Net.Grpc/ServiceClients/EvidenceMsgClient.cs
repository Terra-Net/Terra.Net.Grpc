using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class EvidenceMsgClient : Cosmos.Evidence.V1Beta1.Msg.MsgClient
    {       
        public EvidenceMsgClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public EvidenceMsgClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class WasmTxMsgClient : Terra.Wasm.V1Beta1.Msg.MsgClient
    {       
        public WasmTxMsgClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public WasmTxMsgClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

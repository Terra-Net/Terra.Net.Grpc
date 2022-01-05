using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class WasmTxQueryClient : Terra.Wasm.V1Beta1.Query.QueryClient
    {       
        public WasmTxQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public WasmTxQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

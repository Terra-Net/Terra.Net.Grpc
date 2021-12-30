using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terra.Net.Grpc.ServiceClients;

namespace Terra.Net.Grpc
{
    public class TerraGrpcClient
    {
        public TerraGrpcClient(TerraGrpcClientOptions terraGrpcClientOptions)
        {
            Blocks = new(terraGrpcClientOptions);
            Tx = new(terraGrpcClientOptions);
        }
        public TerraGrpcClient(GrpcChannel grpcChannel)
        {
            Blocks = new(grpcChannel);
            Tx = new(grpcChannel);
        }
        public TerraBlocksServiceClient Blocks { get; }
        public TerraTxServiceClient Tx { get; }

    }
}

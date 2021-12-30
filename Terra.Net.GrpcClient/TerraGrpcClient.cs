using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terra.Net.GrpcClient.ServiceClients;

namespace Terra.Net.GrpcClient
{
    public class TerraGrpcClient
    {
        public TerraGrpcClient(TerraGrpcClientOptions terraGrpcClientOptions)
        {
            Blocks = new TerraBlocksServiceClient(terraGrpcClientOptions);
        }
        public TerraBlocksServiceClient Blocks { get; }
        public TerraTxServiceClient Tx { get; }

    }
}

using Grpc.Net.Client;

namespace Terra.Net.Grpc.ServiceClients
{
    /// <summary>
    /// Cosmos.crisis.v1beta1.tx.proto
    /// </summary>
    public partial class CrisisMsgClient : Cosmos.Bank.V1Beta1.Msg.MsgClient
    {
        public CrisisMsgClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public CrisisMsgClient(GrpcChannel channel) : base(channel)
        {            
        }
    }
}

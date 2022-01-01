using Grpc.Net.Client;

namespace Terra.Net.Grpc.ServiceClients
{
    /// <summary>
    /// Cosmos.crisis.v1beta1.tx.proto
    /// </summary>
    public class CrisisMessageService : Cosmos.Bank.V1Beta1.Msg.MsgClient
    {
        public CrisisMessageService(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public CrisisMessageService(GrpcChannel channel) : base(channel)
        {            
        }
    }
}

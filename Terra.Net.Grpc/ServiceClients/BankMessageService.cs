using Grpc.Net.Client;

namespace Terra.Net.Grpc.ServiceClients
{
    public class BankMessageService : Cosmos.Bank.V1Beta1.Msg.MsgClient
    {
        public BankMessageService(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public BankMessageService(GrpcChannel channel) : base(channel)
        {            
        }
    }
}

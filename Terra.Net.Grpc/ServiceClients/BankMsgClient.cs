using Grpc.Net.Client;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class BankMsgClient : Cosmos.Bank.V1Beta1.Msg.MsgClient
    {
        public BankMsgClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public BankMsgClient(GrpcChannel channel) : base(channel)
        {
        }
    }
}

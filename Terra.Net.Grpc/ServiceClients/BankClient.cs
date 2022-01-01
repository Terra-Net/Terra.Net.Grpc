using Grpc.Net.Client;

namespace Terra.Net.Grpc.ServiceClients
{
    public class BankClient : Cosmos.Bank.V1Beta1.Query.QueryClient
    {
        public BankClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public BankClient(GrpcChannel channel) : base(channel)
        {            
        }
    }
}

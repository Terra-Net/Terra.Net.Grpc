using Grpc.Net.Client;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class BankQueryClient : Cosmos.Bank.V1Beta1.Query.QueryClient
    {
        public BankQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public BankQueryClient(GrpcChannel channel) : base(channel)
        {            
        }
    }
}

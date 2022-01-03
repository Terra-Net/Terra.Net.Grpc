using Grpc.Net.Client;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class AuthQueryClient: Cosmos.Auth.V1Beta1.Query.QueryClient
    {
        public AuthQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public AuthQueryClient(GrpcChannel channel) : base(channel)
        {

        }
    }
}

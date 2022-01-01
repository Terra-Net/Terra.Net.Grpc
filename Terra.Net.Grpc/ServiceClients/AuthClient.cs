using Grpc.Net.Client;

namespace Terra.Net.Grpc.ServiceClients
{
    public class AuthClient: Cosmos.Auth.V1Beta1.Query.QueryClient
    {
        public AuthClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public AuthClient(GrpcChannel channel) : base(channel)
        {

        }
    }
}

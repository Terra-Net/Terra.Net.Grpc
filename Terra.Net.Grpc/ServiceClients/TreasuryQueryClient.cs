using Grpc.Net.Client;


namespace Terra.Net.Grpc.ServiceClients
{
    public partial class TreasuryQueryClient :Terra.Treasury.V1Beta1.Query.QueryClient
    {       
        public TreasuryQueryClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public TreasuryQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}

using Grpc.Net.Client;

namespace Terra.Net.Grpc
{

    public partial class TerraGrpcClientOptions
    {
        public readonly string BaseAddress;
        public readonly GrpcChannelOptions GrpcChannelOptions;

        public TerraGrpcClientOptions(string baseAddress)
        {
            BaseAddress = baseAddress;
            GrpcChannelOptions = new GrpcChannelOptions() { MaxReceiveMessageSize = 25 * 1024 * 1024 };
        }

        public TerraGrpcClientOptions(string baseAddress, HttpClient httpClient)
        {
            BaseAddress = baseAddress;

            GrpcChannelOptions = new GrpcChannelOptions() { MaxReceiveMessageSize = 25 * 1024 * 1024, HttpClient = httpClient };

        }
        public TerraGrpcClientOptions(string baseAddress, GrpcChannelOptions options)
        {
            BaseAddress = baseAddress;
            GrpcChannelOptions = options;
        }
    }


}
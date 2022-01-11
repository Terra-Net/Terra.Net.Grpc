using Google.Protobuf;
using Grpc.Net.Client;
using NUnit.Framework;

namespace Terra.Net.Grpc.Tests
{
    public class Tests
    {
        TerraGrpcClient grpc;
        [SetUp]
        public void Setup()
        {
            grpc = new TerraGrpcClient(GrpcChannel.ForAddress(""));
        }

        [Test]
        public void Test1()
        {
        }
    }
}
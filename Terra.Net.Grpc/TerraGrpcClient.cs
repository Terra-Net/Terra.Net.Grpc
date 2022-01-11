using Google.Protobuf;
using Grpc.Net.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terra.Net.Grpc.Dto;
using Terra.Net.Grpc.ServiceClients;

namespace Terra.Net.Grpc
{
    /*                        
                
                Cosmos.slashing.v1beta1.tx
         
                Cosmos.upgrade.v1beta1.query
                ibc.applications.transfer.v1.tx
                ibc.core.channel.v1.query
                ibc.core.channel.v1.tx
                ibc.core.client.v1.query
                ibc.core.client.v1.tx
                ibc.core.connection.v1.query
                ibc.core.connection.v1.tx
                terra.market.v1beta1.query
                terra.market.v1beta1.tx
                terra.oracle.v1beta1.query
                terra.oracle.v1beta1.tx

                */
    public partial class TerraGrpcClient
    {
        public TerraGrpcClient(TerraGrpcClientOptions terraGrpcClientOptions)
        {
            BlocksQuery = new(terraGrpcClientOptions);
            Tx = new(terraGrpcClientOptions);
            AuthQuery = new(terraGrpcClientOptions);
            AuthZQuery = new(terraGrpcClientOptions);
            AuthZMessage = new(terraGrpcClientOptions);
            BankQuery = new(terraGrpcClientOptions);
            BankMessage = new(terraGrpcClientOptions);
            DistributionQuery = new(terraGrpcClientOptions);
            EvidenceQuery = new(terraGrpcClientOptions);
            EvidenceMsg = new(terraGrpcClientOptions);
            FeegrantQuery = new(terraGrpcClientOptions);
            FeegrantMsg = new(terraGrpcClientOptions);
            GovMsg = new(terraGrpcClientOptions);
            GovQuery = new(terraGrpcClientOptions);
            MintQuery = new(terraGrpcClientOptions);
            ParamsQuery = new(terraGrpcClientOptions);
            TreasuryQuery = new(terraGrpcClientOptions);
            SlashingQuery = new(terraGrpcClientOptions);
            UpgradeQuery = new(terraGrpcClientOptions);
            WasmQuery = new(terraGrpcClientOptions);
        }
        public TerraGrpcClient(GrpcChannel channel)
        {
            BlocksQuery = new(channel);
            Tx = new(channel);
            AuthQuery = new(channel);
            AuthZQuery = new(channel);
            AuthZMessage = new(channel);
            BankQuery = new(channel);
            BankMessage = new(channel);
            DistributionQuery = new(channel);
            EvidenceQuery = new(channel);
            EvidenceMsg = new(channel);
            FeegrantQuery = new(channel);
            FeegrantMsg = new(channel);
            GovMsg = new(channel);
            GovQuery = new(channel);
            MintQuery = new(channel);
            ParamsQuery = new(channel);
            TreasuryQuery = new(channel);
            SlashingQuery = new(channel);
            UpgradeQuery = new(channel);
            WasmQuery = new(channel);
        }
        public readonly BlocksQueryClient BlocksQuery;
        public readonly TxQueryClient Tx;
        public readonly AuthQueryClient AuthQuery;
        public readonly AuthZQueryClient AuthZQuery;
        public readonly AuthZMsgClient AuthZMessage;
        public readonly BankQueryClient BankQuery;
        public readonly BankMsgClient BankMessage;
        public readonly DistributionQueryClient DistributionQuery;
        public readonly EvidenceQueryClient EvidenceQuery;
        public readonly EvidenceMsgClient EvidenceMsg;
        public readonly FeegrantQueryClient FeegrantQuery;
        public readonly FeegrantMsgClient FeegrantMsg;
        public readonly GovMsgClient GovMsg;
        public readonly GovQueryClient GovQuery;
        public readonly MintQueryClient MintQuery;
        public readonly ParamsQueryClient ParamsQuery;
        public readonly SlashingQueryClient SlashingQuery;
        public readonly UpgradeQueryClient UpgradeQuery;
        public readonly TreasuryQueryClient TreasuryQuery;
        public readonly WasmTxQueryClient WasmQuery;

        public async Task<TerraSwapPoolInfo> GetPoolInfo(string poolContractAddress)
        {
            var query = await WasmQuery.ContractStoreAsync(new Wasm.V1Beta1.QueryContractStoreRequest() { ContractAddress = poolContractAddress, QueryMsg = ByteString.CopyFromUtf8("{\"pool\":{}}") });
            return JsonConvert.DeserializeObject<TerraSwapPoolInfo>(query.QueryResult.ToStringUtf8());
        }
        public async Task<SwapSimulationResult> SimulateSwap(string poolContractAddress, ulong amount,  string target, bool fromDenom)
        {
            var q = JsonConvert.SerializeObject(fromDenom ? TerraSwapSimulation.FromNativeToken(target, amount*1000_000) : TerraSwapSimulation.FromToken(target, amount*1000_000));
            var query = await WasmQuery.ContractStoreAsync(new Wasm.V1Beta1.QueryContractStoreRequest() { ContractAddress = poolContractAddress, QueryMsg = ByteString.CopyFromUtf8(q) });
            return JsonConvert.DeserializeObject<SwapSimulationResult>(query.QueryResult.ToStringUtf8());
        }
    }
}

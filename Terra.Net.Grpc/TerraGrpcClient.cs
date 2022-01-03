using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terra.Net.Grpc.ServiceClients;

namespace Terra.Net.Grpc
{
    /*                        
                
                Cosmos.params.v1beta1.query
                Cosmos.slashing.v1beta1.query
                Cosmos.slashing.v1beta1.tx
                Cosmos.tx.v1beta1.service
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
                terra.treasury.v1beta1.query
                terra.wasm.v1beta1.query
                terra.wasm.v1beta1.tx*/
    public partial class TerraGrpcClient
    {
        public TerraGrpcClient(TerraGrpcClientOptions terraGrpcClientOptions)
        {
            BlocksQuery = new(terraGrpcClientOptions);
            TxQuery = new(terraGrpcClientOptions);
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
        }
        public TerraGrpcClient(GrpcChannel channel)
        {
            BlocksQuery = new(channel);
            TxQuery = new(channel);
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
        }
        public readonly BlocksQueryClient BlocksQuery;
        public readonly TxQueryClient TxQuery;
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
    }
}

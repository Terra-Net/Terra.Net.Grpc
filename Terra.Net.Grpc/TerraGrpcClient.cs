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
                Cosmos.distribution.v1beta1.query
                Cosmos.distribution.v1beta1.tx
                Cosmos.evidence.v1beta1.query
                Cosmos.evidence.v1beta1.tx
                Cosmos.feegrant.v1beta1.query
                Cosmos.feegrant.v1beta1.tx
                Cosmos.gov.v1beta1.query
                Cosmos.gov.v1beta1.tx
                Cosmos.mint.v1beta1.query
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
    public class TerraGrpcClient
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
        }
        public readonly BlocksClient BlocksQuery;
        public readonly TxClient TxQuery;
        public readonly AuthClient AuthQuery;
        public readonly AuthZClient AuthZQuery;
        public readonly AuthZTxClient AuthZMessage;
        public readonly BankClient BankQuery;
        public readonly BankMessageService BankMessage;



    }
}



using DesignPatterns2022.Adapter;
using DesignPatterns2022.Adapter.DataProcessor;
using DesignPatterns2022.Adapter.Network;

INetworkClient network = new NetworkClient();
network.SendRequest("69.420");

IDataProcessor dataProc = new DataProcessor();
dataProc.SendNetworkRequest("5.5.5.5", "2345234sdfg2345");

Adapter adapter = new Adapter(dataProc);
adapter.SendRequest("7.7.7.7");
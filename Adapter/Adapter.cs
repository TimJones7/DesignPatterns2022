using DesignPatterns2022.Adapter.DataProcessor;
using DesignPatterns2022.Adapter.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Adapter
{
    internal class Adapter : INetworkClient
    {
        private readonly IDataProcessor _dataProcessor;

        public Adapter(IDataProcessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
        }
        public void SendRequest(string ipAddress)
        {
            var apiKey = "9278634985ty23ruhgt2345";
            _dataProcessor.SendNetworkRequest(ipAddress, apiKey);
        }
    }
}

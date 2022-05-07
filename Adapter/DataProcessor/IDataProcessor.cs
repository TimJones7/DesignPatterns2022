using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Adapter.DataProcessor
{
    internal interface IDataProcessor
    {
        bool DataProcess();

        void SendNetworkRequest(string ip, string apiKey);
    }
}

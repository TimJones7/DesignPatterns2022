using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Adapter.Network
{
    internal class NetworkClient : INetworkClient
    {
        public void SendRequest(string ipAddress)
        {
            Console.WriteLine("Network Client Request => Sent to: " + ipAddress);
        }
    }
}

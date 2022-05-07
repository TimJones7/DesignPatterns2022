using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Adapter.Network
{
    internal interface INetworkClient
    {
        void SendRequest(string ipAddress);
    }
}

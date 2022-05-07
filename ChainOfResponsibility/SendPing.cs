using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.ChainOfResponsibility
{
    internal class SendPing : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            { 
                Console.WriteLine("Send Ping Faile. Sending ARP");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send Ping Success");
            }
        }


        public void SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}

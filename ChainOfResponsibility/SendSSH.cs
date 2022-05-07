using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.ChainOfResponsibility
{
    internal class SendSSH : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if(request.Success == false)
            {
                Console.WriteLine("Send SSH Faile. Sending Ping");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send SSH Success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}

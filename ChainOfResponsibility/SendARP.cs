using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.ChainOfResponsibility
{
    internal class SendARP : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send ARP Failed.");
                if(next != null) 
                { 
                    next.SendRequest(request); 
                }
                else
                {
                    Console.WriteLine("Network transmission failed!! Terminating!!");
                }
                
            }
            else
            {
                Console.WriteLine("Send ARP Success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}

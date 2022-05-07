using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Strategy
{
    internal class DNS : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Sending DNS Request!");
        }
    }
}

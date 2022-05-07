﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Facade
{
    internal class Socket
    {
        public int IP { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }

        public Socket(string protocol)
        {
            this.Protocol = protocol;
        }
        public void BuildSocket()
        {
            Console.WriteLine("Socket has been built");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Proxy
{
    internal class SuperSecretDatabaseProxy : ISuperSecretDatabase
    {
        private SuperSecretDatabase superSecretDatabase;
        private string databaseName;
        private string password;

        public SuperSecretDatabaseProxy(string databaseName, string password)
        {
            this.databaseName = databaseName;
            this.password = password;
        }



        public void DisplayDatabaseName()
        {
            if (password.Equals("Password"))
            {
                if(superSecretDatabase == null)
                {
                    superSecretDatabase = new SuperSecretDatabase(databaseName);
                }
                superSecretDatabase.DisplayDatabaseName();
            }
        }

    }
}

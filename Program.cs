

using DesignPatterns2022.Proxy;

ISuperSecretDatabase database = new SuperSecretDatabaseProxy("testDB", "Password");

database.DisplayDatabaseName();
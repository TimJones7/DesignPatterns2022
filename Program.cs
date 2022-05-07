



using DesignPatterns2022.Strategy;

Context contextOne = new Context(new ARP());
Context contextTwo = new Context(new Ping());
Context contextThree = new Context(new DNS());



contextOne.ExecuteStrategy();
contextTwo.ExecuteStrategy();
contextThree.ExecuteStrategy();
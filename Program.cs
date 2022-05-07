




using DesignPatterns2022.ChainOfResponsibility;

IChain obj1 = new SendSSH();
IChain obj2 = new SendPing();
IChain obj3 = new SendARP();


obj1.SetNext(obj2);
obj2.SetNext(obj3);

NetworkModel request = new NetworkModel("7.7.7.7", false);

obj1.SendRequest(request);




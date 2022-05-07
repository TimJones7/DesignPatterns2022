

using DesignPatterns2022.Facade;

NetworkFacade networkFacade = new NetworkFacade("8.8.8.8", "UDP");

networkFacade.BuildNetworkLayer();
networkFacade.SendPacketOverNetwork();
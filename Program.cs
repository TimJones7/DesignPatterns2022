

using DesignPatterns2022.Factory.NetworkFactory;
using DesignPatterns2022.Factory.NetworkUtility;


NetworkFactory factory = new NetworkFactory();

var ping = factory.GetNetworkInstance("ping");
var dns = factory.GetNetworkInstance("dns");
var arp = factory.GetNetworkInstance("arp");

ping.SendRequest("13.456.123", 2); 
dns.SendRequest("13.456.123", 4);
arp.SendRequest("14.56.123", 4);


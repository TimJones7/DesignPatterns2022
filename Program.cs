// See https://aka.ms/new-console-template for more information



using DesignPatterns2022.Singleton;

Singleton object1 = Singleton.Instance();
Singleton object2 = Singleton.Instance();

if(object1 == object2)
{
    Console.WriteLine("These objects are the same");

}

int val = 0;
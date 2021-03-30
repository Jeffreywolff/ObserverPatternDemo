using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();

            Subscriber subscriber1 = new Subscriber("subscriber 1");
            channel.Subscribe(subscriber1);

            Subscriber subscriber2 = new Subscriber("subscriber 2");
            channel.Subscribe(subscriber2);

            Subscriber subscriber3 = new Subscriber("subscriber 3");
            channel.Subscribe(subscriber3);

            channel.Inventory++;

            Console.ReadLine();
        }
    }
}

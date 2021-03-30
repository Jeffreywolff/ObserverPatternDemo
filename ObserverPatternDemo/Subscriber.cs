using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subscriber : ISubscriber
    {
        public string subscriberName { get; private set; }

        public Subscriber(string name)
        {
            subscriberName = name;
        }

        public void Update()
        {
            Console.WriteLine(subscriberName + ": A new video has arrived!");
        }
    }
}

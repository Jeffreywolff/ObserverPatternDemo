using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Channel : IChannel
    {
        private List<Subscriber> subscriber = new List<Subscriber>();
        private int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void Subscribe(Subscriber sub)
        {
            subscriber.Add(sub);
        }

        public void Unsubscribe(Subscriber sub)
        {
            subscriber.Remove(sub);
        }

        public void Notify()
        {
            foreach (var subscriber in subscriber)
            {
                subscriber.Update();
            }
        }
    }
}

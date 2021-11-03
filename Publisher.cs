using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPatern
{
    class Publisher: IPerson
    {
        public string _name { get; set; }
        public List<IObserver> Flowers = new List<IObserver>();

        public Publisher(string name)
        {
            _name = name;
        }

        public async Task SendMasage(string massage)
        {
            Console.WriteLine(_name + " say: " + massage);
            Send(massage);
        }

        public async Task Add(IObserver model)
        {
            Flowers.Add(model);
        }

        public async Task Remove(IObserver model)
        {
            Console.WriteLine("remove");
        }

        public async Task Send(string massege)
        {
            foreach (var item in Flowers)
            {
                item.Update(_name, massege);
            }
        }
    }
}

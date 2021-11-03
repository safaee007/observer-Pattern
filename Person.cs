using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPatern
{
    class Person : IObserver
    {
        public string _name { get; set; }
        public Person(string name)
        {
            _name = name;
        }
        public async Task Update(string name, string massge)
        {
            Console.WriteLine(_name + " Resive massage from " + name);
        }
    }
}

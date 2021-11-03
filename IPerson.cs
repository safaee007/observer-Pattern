using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPatern
{
    interface IPerson
    {
        Task Add(IObserver model);
        Task Remove(IObserver model);
        Task Send(string massege);
    }
}

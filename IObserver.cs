using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPatern
{
    interface IObserver
    {
        Task Update(string name, string massge);
    }
}

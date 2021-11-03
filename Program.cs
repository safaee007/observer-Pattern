using System;

namespace observerPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher account = new Publisher("Saeed");


            Person p = new Person("A");
            Person p2 = new Person("B");


            account.Add(p);
            account.Add(p2);

            account.SendMasage("Salam be hame");
        }
    }
}

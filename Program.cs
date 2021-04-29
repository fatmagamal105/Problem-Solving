using System;

namespace OOP06N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Widget w = new Widget();
            w.First();


            ((IWidget)w).Second();
        }
    }
}

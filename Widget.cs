using System;
using System.Collections.Generic;
using System.Text;

namespace OOP06
{
    class Widget : IWidget
    {
        public virtual void First()
        {
            Console.WriteLine("inside versiual method");
        }

        void IWidget.Second()
        {
            Console.WriteLine("Inside explicity Method");
        }
    }
}

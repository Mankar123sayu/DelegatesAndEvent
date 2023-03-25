using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void DelHandler();
    public class EventDemo
    {
        public event DelHandler demo;
        public void India()
        {
            Console.WriteLine("India");
        }
        public void USA()
        {
            Console.WriteLine("USA");
        }
        public void England()
        {
            Console.WriteLine("England");
        }
        public void Run()
        {
            demo += new DelHandler(India);
            demo += new DelHandler(USA);
            demo += new DelHandler(England);
            demo.Invoke();
        }
    }
}
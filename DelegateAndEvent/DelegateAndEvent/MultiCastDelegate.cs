using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int MultiOpration(int x, int y);
    public class MultiCastDelegates
    {
        public static int Addition(int a, int b)
        {
            Console.WriteLine("Add" + (a + b));
            return a + b;
        }
        public static int Multiplication(int a, int b)
        {
            Console.WriteLine("Mul" + a * b);
            return a * b;
        }
        public void Run()
        {
            MultiOpration multi = Addition;
            multi += Multiplication;
            multi(1, 2);
            multi(2, 3);
        }
    }
}

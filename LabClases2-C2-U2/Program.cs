using Clases;
using System;

namespace LabClases2_C2_U2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = b;
            a.F();
            b.F();
            a.G();
            b.G();
            Console.ReadKey();

        }
    }
}

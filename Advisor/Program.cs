using System;
using CommonLibrary;

namespace Advisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Xpert xpert = new Xpert();
            Console.WriteLine(xpert.Advice());
        }
    }
}

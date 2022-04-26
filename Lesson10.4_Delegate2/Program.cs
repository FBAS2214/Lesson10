using System;

namespace Lesson10_4_Delegate2
{
    delegate void Del(string s);

    class TestClass
    {
        static void Hello(string s)
        {
            Console.WriteLine($"  Hello, {s}!");
        }

        static void Goodbye(string s)
        {
            Console.WriteLine($"  Goodbye, {s}!");
        }

        static void Main()
        {
            Del a, b, c, d;

            a = Hello;

            b = Goodbye;


            c = a + b;
            
            d = c - a;

            Console.WriteLine("Invoking delegate a:");
            a("A");
            Console.WriteLine("Invoking delegate b:");
            b("B");
            Console.WriteLine("Invoking delegate c:");
            c("C");
            Console.WriteLine("Invoking delegate d:");
            d("D");
        }
    }
}
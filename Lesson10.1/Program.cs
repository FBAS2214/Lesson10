using System;

namespace Lesson10_1
{
    // Tuple
    class Program
    {
        public static (int, string) DoSomething()
        {
            return (10, "Some");
        }

        static void Main()
        {
            // (int, string) tuple1 = (5, "Hello");
            // (int count, string name) tuple2 = (5, "Hello");
            // Tuple<char, short, double> tuple3 = new('A', 2, 1.5);
            // 
            // Console.WriteLine(tuple1.Item1);
            // Console.WriteLine(tuple1.Item2);
            // 
            // Console.WriteLine(tuple2.count);
            // Console.WriteLine(tuple2.name);
            // 
            // Console.WriteLine(tuple3.Item1);
            // Console.WriteLine(tuple3.Item2);
            // Console.WriteLine(tuple3.Item3);



            // int a = 10;
            // int b = 20;
            // 
            // (a, b) = (b, a);
            // 
            // Console.WriteLine($"a is {a}, b is {b}");


            // Console.WriteLine(DoSomething());
        }
    }
}
using System;

namespace Lesson10_6_Delegate4
{
    class Program
    {
        static void Any()
        {
            Console.WriteLine("Working...");
        }

        static void Some(int value)
        {
            Console.WriteLine($"Working...int {value}");
        }


        static void Main(string[] args)
        {
            // Action    (return void, param 0-16)
            // Predicate (return bool, param 1)
            // Func      (return any,  param 0-16) (void-)


            // Action action1 = () => Console.WriteLine("Do something");
            // Action action2 = Any;
            // Action<int> action3 = Some;
            // 
            // action3(10);



            // Next lesson
        }
    }
}
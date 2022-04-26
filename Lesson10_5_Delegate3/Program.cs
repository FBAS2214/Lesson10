using System;

namespace Lesson10_5_Delegate3
{
    delegate void MyDel(string text);

    class Program
    {
        static void Hello(string s)
        {
            Console.WriteLine($"  Hello, {s}!");
        }

        static void Main()
        {
            MyDel myDel = null;

            myDel += Hello;
            myDel += delegate (string str) { Console.WriteLine(str); };
            myDel += s => Console.WriteLine(s);

            // DoSomething(myDel);


            Console.WriteLine(myDel.GetInvocationList().Length);


            foreach (var del in myDel.GetInvocationList())
            {
                del.DynamicInvoke(new string[] {"Param1"});
                // del.Method.Invoke(null, new string[] { "Param2" });
            }

        }

        static void DoSomething(MyDel myDel)
        {
            myDel("Param");
        } 
    }
}
using System;

namespace Lesson10_3_Delegate1
{
    public delegate void MyDelegate();
    public delegate void MyDelegateWithParam(string str);
    public delegate float DelWithReturnType(float n1, float n2);

    class Program
    {
        static void Main()
        {

            ////////////////////////////////////
            // Delegate
            // MulticastDelegate

            // // MyDelegateWithParam del = new MyDelegateWithParam (Console.WriteLine);
            // // MyDelegateWithParam del = new(Console.WriteLine);
            // MyDelegateWithParam del = Console.WriteLine;

            // del("Hakuna");
            // del.Invoke("Hakuna");



            ////////////////////////////////////

            Methods methods = new();

            MyDelegate myDelegate = methods.Boo;
            myDelegate += methods.Foo;
            myDelegate -= methods.Boo;

            myDelegate = methods.DoSomething;

            // myDelegate.Invoke();
            // myDelegate();




            ////////////////////////////////////


            // DelWithReturnType del = null;
            // del += methods.Add;
            // del += methods.Subt;
            // del += methods.Mult;
            // 
            // Console.WriteLine(del(5, 2));
        }
    }

    class Methods
    {
        public void Foo() => Console.WriteLine("Foo");
        public void Boo() => Console.WriteLine("Boo");
        public void DoSomething() => Console.WriteLine("DoSomething");

        public float Add(float a, float b)
        {
            Console.WriteLine("Add");
            return a + b;
        }
            
        public float Mult(float a, float b)
        {
            Console.WriteLine("Mult");
            return a * b;
        }

        public float Subt(float a, float b)
        {
            Console.WriteLine("Subt");
            return a - b;
        }

    }
}
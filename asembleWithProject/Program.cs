using System;
using ClassLibrary1;
namespace asembleWithProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.sum(12, 3);
            obj.mul(12, 10);
            Console.WriteLine("save :");
            
            Console.WriteLine("Hello World!");
        }
    }
}

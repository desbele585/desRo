using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();
            p.FirstName = "Desbele";
            p.LastName = "Bitow";
            Console.WriteLine(p.GetFullName("Desbele" +  "Bitow"));
           
           
        }
    }
}

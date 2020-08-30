using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();
            p.FirstName = "Meles";
            p.LastName = "Weldemicael";
            Console.WriteLine(p.GetFullName("Desbele" +  "Bitow"));
            Console.WriteLine("Now git is on its way of downfall");
           
           
        }
    }
}

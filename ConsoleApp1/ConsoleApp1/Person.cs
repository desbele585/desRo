using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public  class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonAge { get; set; }
        public static List<string> pizzas = new List<string>()
        { "Marigheta", "Kyckling" ,"KöttPizza","pastaPizza"
        };
        public string GetFullName( string FullName)

        { 
            FullName = FirstName + " " + LastName;
                return FullName;
        }
        public void AddPerson()
        {
            List<Person> persons = new List<Person>();
            persons.Add(pizzas);
        }

    }
}

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
        public string GetFullName( string FullName)
        { 
            FullName = FirstName + " " + LastName;
                return FullName;
        }

    }
}

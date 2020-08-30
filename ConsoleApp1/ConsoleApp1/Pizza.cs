using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Pizza
    {
        public int price { get; set; }
        public string size { get; set; }
        public string name { get; set; }
        public void Pay()
        {
            Payment.Pay();

        }

    }
}

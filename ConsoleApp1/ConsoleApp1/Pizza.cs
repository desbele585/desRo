using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Pizza
    {
        public int price { get; set; }
        public Size size { get; set; }
        public string name { get; set; }
                public void Pay()
        {
            Payment.Pay();

        }
        public void BuyPizza()
        {
            List<Pizza> pizzas = new List<Pizza>();
            
        }
        public void GetPerson()
        {

        }

    }
    public enum Size 
    {  small , medium, largest
    }
   
}

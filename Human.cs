using System;
using Drinks;

namespace Mammals
{
    class Human {

        public string name;

        public Human(string name)
        {
            this.name = name;
        }

        public void ConsumeBeverage(Drink d)
        {
            try
            {
                d.Imbibe();
            }
            catch(Exception e)
            {
                Console.WriteLine("Order another one!");
                Console.WriteLine(e);
            }

            if(d is IAlcoholic)
            {
                Console.WriteLine($"{this.name} is feeling tipsy!");
            }
        }

    }
}
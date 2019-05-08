using System;
using Mammals;

namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Water w = new Water(false, "clear", false);
            // w.Imbibe();
            // w.Imbibe();
            Wine v = new Wine("white", false, "pinot grigio", "Napa Valley", 2016, 0.12);
            // v.Imbibe();
            // v.Imbibe();
            Human bob = new Human("Bob");
            bob.ConsumeBeverage(w);
            bob.ConsumeBeverage(w);
            bob.ConsumeBeverage(v);
            bob.ConsumeBeverage(v);
        }
    }
}

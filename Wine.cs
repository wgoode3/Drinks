using System;

namespace Drinks
{
    class Wine : Drink, IAlcoholic 
    {
        
        public string type;
        public string region;
        public int year;
        public double apv {get;}

        public Wine(string color, bool isCarb, string type, string region, int year, double apv) : base(isCarb, color)
        {
            this.type = type;
            this.region = region;
            this.year = year;
            this.apv = apv;
        }

        public override void Imbibe()
        {
            if(this.isFull){
                Console.WriteLine("sip sip...");
            } 
            else 
            {
                Console.WriteLine("You stare at the empty glass in dismay");
            }
            this.isFull = false;
        }

    }
}
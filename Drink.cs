using System;

namespace Drinks
{
    abstract class Drink 
    {

        protected bool isFull{get;set;}
        public bool isCarbonated;
        public string color;

        public Drink (bool isCarb, string color)
        {
            this.isFull = true;
            this.isCarbonated = isCarb;
            this.color = color;
        }

        public virtual void Imbibe()
        {
            if(this.isFull){
                Console.WriteLine("glug glug...");
            } 
            else 
            {
                // Console.WriteLine("You stare at the empty glass in dismay");
                throw new DrinkIsEmptyException("Drink is empty!");
            }
            this.isFull = false;
        }

    }
}
using System;

namespace Drinks
{
    class Water : Drink 
    {
    
        public bool isHot;

        public Water(bool isCarb, string color, bool isHot) : base(isCarb, color)
        {
            this.isHot = isHot;
        }

        // public override void Imbibe()
        // {
        //     base();
        // }

    }
}
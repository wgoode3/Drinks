using System;

namespace Drinks
{
    class DrinkIsEmptyException : Exception {
        public DrinkIsEmptyException(string message) : base(message) 
        {}
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird:Animal
    {
        public Bird()
        {
            Legs = 2;
            FoodType = "worms";

        }
        public bool HasWings { get; set; } = true;
        public bool HasFeathers { get; set; } = true;
        public string FeatherColors { get; set; }
        public string SoundsLike { get; set; }





    }
}

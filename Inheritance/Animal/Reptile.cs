using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile:Animal   
    {
        public Reptile()
        {
            FoodType = "Instects";
            Legs = 4;
            LifeSpan = 200;
            
        }

        bool Scales = true;
        public string Color { get; set; }
        public bool IsColdBlooded = true; 
        public string ScaleFeel { get; set; }



}
    }


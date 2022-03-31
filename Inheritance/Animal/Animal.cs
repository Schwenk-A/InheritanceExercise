using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Animal
    {
        public Animal()
        {

        }
        // give this class 4 members that all Animals have in common
        public int Legs { get; set; }
        public string FoodType { get; set; }
        public int LifeSpan { get; set; }
        public int YearofBirth { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab007
{
    [Comment("This is class Pig")]
    public class Pig : Animal
    {
        public Pig() : base() { }
        public Pig(string country, bool hideFromOtherAnimals,
            string name, string whatAnimal) : 
            base(country, hideFromOtherAnimals, name, whatAnimal) { }

        public override eFavouriteFood GetFavouriteFood()
        {
            return eFavouriteFood.Everything;
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello! This is Pig");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab007
{
    [Comment("This is class Lion")]
    public class Lion : Animal
    {
        public Lion() : base() { }
        public Lion(string country, bool hideFromOtherAnimals,
            string name, string whatAnimal) : 
            base(country, hideFromOtherAnimals, name, whatAnimal) { }

        public override eFavouriteFood GetFavouriteFood()
        {
            return eFavouriteFood.Meat;
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello! This is Lion");
        }
    }
}
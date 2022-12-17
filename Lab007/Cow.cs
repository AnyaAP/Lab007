using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab007
{
    [Comment("This is class Cow")]
    public class Cow : Animal
    {
        public Cow() { }
        public Cow(string country, bool hideFromOtherAnimals,
            string name, string whatAnimal) : 
            base(country, hideFromOtherAnimals, name, whatAnimal) { }

        public override eFavouriteFood GetFavouriteFood()
        {
            return eFavouriteFood.Plants;
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello! This is Cow");
        }
    }
}
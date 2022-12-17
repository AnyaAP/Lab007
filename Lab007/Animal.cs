using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Lab007
{
    [Comment("This is class Animal")]
    [XmlInclude(typeof(Cow))]
    [XmlInclude(typeof(Lion))]
    [XmlInclude(typeof (Pig))]
    public abstract class Animal
    {
        public Animal() { }
        public Animal(string country, bool hideFromOtherAnimals,
            string name, string whatAnimal)
        {
            Country = country;
            HideFromOtherAnimals = hideFromOtherAnimals;
            Name = name;
            WhatAnimal = whatAnimal;
        }

        public string Country { get; set; } = "";

        public bool HideFromOtherAnimals { get; set; } = false;

        public string Name { get; set; } = "";

        public string WhatAnimal { get; set; } = "";

        private eClassificationAnimal Classification;

        public void Deconstruct(out string country, out bool hideFromOtherAnimals,
            out string name, out string whatAnimal)
        {
            country = Country;
            hideFromOtherAnimals = HideFromOtherAnimals;
            name = Name;
            whatAnimal = WhatAnimal;
        }

        public void GetClassificationAnimal()
        {
            if (this.GetFavouriteFood() == eFavouriteFood.Plants)
                Classification = eClassificationAnimal.Herbivores;
            else if (this.GetFavouriteFood() == eFavouriteFood.Meat)
                Classification = eClassificationAnimal.Carnivores;
            else if (this.GetFavouriteFood() == eFavouriteFood.Everything)
                Classification = eClassificationAnimal.Omnivores;
        }
        public abstract eFavouriteFood GetFavouriteFood();

        public abstract void SayHello();
    }
}
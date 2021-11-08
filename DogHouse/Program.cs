using System;
using System.Collections.Generic;

namespace DogHouse
{
    class Program
    {
        public static void Main(string[] args)
        { 
            Dogs annabelle = new Dogs("Annabelle", 2, "Golden");
            Dogs betty = new Dogs("Betty", 7, "Chihuahua");

            List<Dogs> dogs = new List<Dogs>();
            dogs.Add(annabelle);
            dogs.Add(betty);

            List<Cats> cats = new List<Cats>();
            cats.Add(new Cats("Barbie", 1, "White"));
            cats.Add(new Cats("Buttercup", 3, "Siamese"));
            cats.Add(new Cats("Charlie", 5, "Black"));

            foreach (var cat in cats)
            {
                Console.WriteLine($"Name:{cat.Name} Age: {cat.Age} Breed: {cat.Breed}");
            }

            //Console.WriteLine(annabelle.GoodWithKids());
            //Console.WriteLine(betty.GoodWithKids());
            //Console.ReadLine();
            

        }
    }
}

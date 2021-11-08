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

            

            Console.WriteLine(annabelle.GoodWithKids());
            Console.WriteLine(betty.GoodWithKids());
            Console.ReadLine();

            //foreach (Dogs availabledogs in Dogs)
            //{
                //Console.WriteLine();
            //}

           // List<Dogs> availabledogs = new List<Dogs>();
           // availabledogs.Add(dog1);
           // availabledogs.Add(dog2);

            

        }
    }
}

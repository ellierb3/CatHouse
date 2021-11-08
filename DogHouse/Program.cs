using System;
using System.Collections.Generic;
using System.Collections.Generic.List;

namespace DogHouse
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!")
            Dogs dog1 = new Dogs("Annabelle", 2, "Golden");
            Dogs dog2 = new Dogs("Betty", 7, "Chihuahua");


            List<Dogs> availabledogs = new List<Dogs>();
            availabledogs.Add(dog1);
            availabledogs.Add(dog2);

            Console.WriteLine(availabledogs);

        }
    }
}

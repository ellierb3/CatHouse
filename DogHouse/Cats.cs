﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatHouse
{
    class Cats: Info
    {
        public Cats(string catName, int catAge, string catBreed)
        {
            Name = catName;
            Age = catAge;
            Breed = catBreed;
        }

        public bool GoodWithKids()
        {
            if (Age <= 5)
            {
                return true;
            }
            return false;
        }

        public static void SortCats()
        {
            Console.WriteLine("PLaceholderrr");
        }

       
        // public static void BlackCats()
        // {
        // string blackcats = Cats.
        // Console.WriteLine($"There are {animals}");
        // }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class MainMenu
    {
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my app");
            Console.WriteLine("");
            Console.WriteLine("1. Adoptable Dogs");
            Console.WriteLine("2. Adoptable Cats");
            Console.WriteLine("3. Quit");
            Console.WriteLine("Please select an option from above");

            string userselection;
            userselection = Console.ReadLine();

        }
    }
}

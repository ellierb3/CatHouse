using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    public class Dogs : Info
    {
        public Dogs(string dogName, int dogAge, string dogBreed)
        {
            Name = dogName;
            Age = dogAge;
            Breed = dogBreed;
        }

        public bool GoodWithKids()
        {
            if (Age <= 5)
            {
                return true;
            }
            return false;
        }
        
        
    }
}

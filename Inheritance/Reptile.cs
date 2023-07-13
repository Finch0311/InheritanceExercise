using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class Reptile : Animal
    {
       public Reptile()
        {
            HasMouth = true;
            IsAlive = true;
            HasEyes = 1;
            IsVertebrate = true;

        }
        public string ColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public string CanSwim { get; set; }
        public bool CanGrowTail { get; set; }


    }
}

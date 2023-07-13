using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal 
    {
      public Bird() 
        {
            HasMouth = true;
            IsAlive = false;
            HasEyes = 2;
            IsVertebrate = true;
        }
        public string CanSing { get; set; }
        public string CanFly { get; set; }
        public bool EatsBugs { get; set; }
        public bool DoMigrate { get; set; }
    }

    
}

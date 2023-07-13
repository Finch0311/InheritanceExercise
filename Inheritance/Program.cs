using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal                                        DONE
            // give this class 4 members that all Animals have in common    Done


            // Create a class Bird                                      DONE
            // give this class 4 members that are specific to Bird      DONE
            // Set this class to inherit from your Animal Class         DONE

            // Create a class Reptile                                   DONE
            // give this class 4 members that are specific to Reptile   DONE
            // Set this class to inherit from your Animal Class         DONE    



            var myBird = new Bird();

            myBird.CanSing = "I tawt I taw a puddy tat. I did! I did! I taw a puddy tat!";
            myBird.CanFly = "It's a bird! It's a plane! No it's an object derived from the Animal class?";
            myBird.EatsBugs = true;
            myBird.DoMigrate = true;


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile();

            myReptile.CanGrowTail = true;
            myReptile.CanSwim = "Captain Hook knows best, but most reptiles can swim...";
            myReptile.HasScales = true;
            myReptile.ColdBlooded = "What do you call a lizard assassin? A cold-blooded killer.";



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine($"{myBird.CanFly}");
            Console.WriteLine($"{myBird.CanSing}");    
            Console.WriteLine($"Do birds eat bugs? {myBird.EatsBugs}");
            Console.WriteLine($"Will birds migrate? {myBird.DoMigrate}");

            Console.WriteLine($"{myReptile.ColdBlooded}");
            Console.WriteLine($"Can some reptiles regrow tails? {myReptile.CanGrowTail}");
            Console.WriteLine($"{myReptile.CanSwim}");
            Console.WriteLine($"Do most reptiles have scales? {myReptile.HasScales}");






        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////When we intialize a new object, it is called instantiating (creating a new instance)
            ////An object needs to be instantiated before it can be used
            ////All objects of a specific type are created from the same template - CLASS
            //// All objects from a class will have the same number and type of states, 
            ////But each instance can have its own unique values


            ////the format we use to instantiate an object looks like this:
            ////ClassName objectName = new ClassName();
            //Cat firstCat = new Cat();
            //firstCat.Name = "Mittens";
            //Console.WriteLine(firstCat.Age);

            //Cat secondCat = new Cat("Oz", 3, "Orange and white");
            //secondCat.Name = ("Ozzy");
            //Console.WriteLine(secondCat.Name);
            //Console.WriteLine(secondCat.Age);
            //secondCat.Eat();
            ////To create a new object, we use a special method called a CONSTUCTOR

            ////Thinking about object in real like, create (either hand-write or type)
            ////three examples of objects, they should have five states and five behaviors

            //Superhero firstHero = new Superhero();
            //firstHero.StrengthLevel = 100;
            //firstHero.HasCape = true;

            //firstHero.BattleNemesis();

            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            //firstHero.BattleNemesis();

            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);
            //firstHero.BattleNemesis();

            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);
            //firstHero.BattleNemesis();

            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            //Superhero secondHero = new Superhero("Diamond Daniel");
            //Console.WriteLine(secondHero.StrengthLevel);

            //secondHero.AllyGained();
            //Console.WriteLine(secondHero.StrengthLevel);

            Superhero thirdHer0 = new Superhero("The Best Ever", "Black Unitard", 1000, "Being the Best", false);

            thirdHer0.BattleNemesis();
            Console.WriteLine("Oh no now my costume is {0}", thirdHer0.Costume);
            Console.WriteLine("and now my strength is only {0}", thirdHer0.StrengthLevel);
        }
    }
}

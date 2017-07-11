using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Cat
    {
        //Inside our class we create a blueprint for our object.
        //Classes are templates in OOP that we use to create objects
        //They should always be named in Pascal Case

        //In OOP there are two types of states:
        //Fields variablies that belong to a class

        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        //properties are a mix between field and methods that allow controlled access
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
        }
        //We also have behaviors
        //Methods - repeatable/reusable sections of code - Actions
        //and Constructors - Specialized methods that are used when instantiating an object
        //          -Allows us to control the state of an object upon creation
        //          Allow us to perform any actions the object might need upon creation
        //          Always share the name of the class

        public Cat()
        {
            //This is an example of a default constructor a default takes no arguements/parameters
        }
        //You can have as many constructors as you want/need as long as they have unique signatrures.
        //by signatures i mean parameters in the parentheses after the constructor name.


        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry?{0}", isHungry);
        }
    }

}


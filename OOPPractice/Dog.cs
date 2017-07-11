using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Dog
    {
        //Create a Dog class
        //Your dog class should have fields for ahir length, height, running speed, and weight
        //Your class should have the following behavoirs: run, bark, potty, cuddle
        //Fields
        private string hairLength;
        private int height;
        private int runningSpeed;
        private double weight;
        private bool crap = true;

        //Properties
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }

        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public double BarkVolume { get; set; }


        //Constructors
        public Dog()
        {

        }
        public Dog(string hairLength, int height, int runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public int Run()
        {
            Console.WriteLine("Go doggy go!!");
            RunningSpeed -= 1;
            return RunningSpeed;
        }

        public void Bark()
        {
            Console.WriteLine("Bork bork bork!!");
        }

        public void Potty()
        {
            if (crap == true)
            {
                Console.WriteLine("Your dog just pooped in your shoe");
            }
            else
            {
                Console.WriteLine("Your dog has to relieve itself");
            }
        }
        public void Cuddle()
        {
            Console.WriteLine("So Sweet!");
        }
    }
}

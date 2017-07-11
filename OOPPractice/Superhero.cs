﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Superhero
    {
        //4 field
        private string costume;
        private string name;
        private string power;
        private int strengthLevel;
        private bool hasCape;


        //4 Properties
        public string Costume
        {
            get { return this.costume; }
            set { this.costume = value; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public string Power
        {
            get { return this.power; }
        }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        //3 Constructors

        public Superhero()
        {
            //This is my default constructor
        }

        public Superhero(string name)
        {
            this.name = name;
            this.strengthLevel = 100;
        }

        public Superhero(string name, string costume, int strengthLevel, string power, bool hasCape)
        {
            this.costume = costume;
            this.name = name;
            this.strengthLevel = strengthLevel;
            this.power = power;
            this.hasCape = hasCape;
        }
        //2 methods
    }
}

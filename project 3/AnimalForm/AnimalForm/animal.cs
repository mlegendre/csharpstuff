using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalForm
{
    class animal
    {
        //properties to be used by the class
        public string Legs { get; set; }
        public string Skin { get; set; }
        public string Talk { get; set; }
        public string Eat { get; set; }
        public string Move { get; set; }

        //return statement for method call
        public string AnimalMove(string move)
        {
            return "This animal moves " + move;
        }
        //return statement for method call
        public string SkinSurface()
        {
            return "This animal's skin is " + Skin;
        }
        //return statement for method call
        public string LegCount()
        {
            return "Number of legs = " + Legs;

        }
        //return statement for method call
        public string EatWhat(string eat)
        {
            return "This animal eats " + eat;
        }

    }
    //constructor to accept and set value for legs and skin properties
    //Extended Mouse class of animal class
    class Mouse : animal
    {
        public Mouse()
        {
            Legs = "A mouse has 4 legs";
            Skin = "Skin";
            Talk = "Talk";
            Eat = "Eats";
        }
        //return statement for method call
        public string MouseUnique()
        {
            return "This animal fights crime";
        }
    }
    //constructor to accept and set value for legs and skin properties
    //Extended Mouse class of animal class
    class Cat : animal
    {
        public Cat()
        {
            Legs = "A cat has 4 legs";
            Skin = "Skin";
            Talk = "Talk";
            Eat = "Eats";
        }
        //return statement for method call
        public string CatUnique()
        {
            return "This animal sits and expects you to do everything.";
        }
    }
    //constructor to accept and set value for legs and skin properties
    //Extended Dog class of animal class
    class Dog : animal
    {
        public Dog()
        {
            Legs = "A dog has 4 legs";
            Skin = "Skin";
            Talk = "Talk";
            Eat = "Eats";
        }
        //return statement for method call
        public string DogUnique()
        {
            return "I like to run jump and play as long as you feed me.";
        }
    }
    //constructor to accept and set value for legs and skin properties
    //Extended Mouse class of animal class
    class Rhino : animal
    {
        public Rhino()
        {
            Legs = "A rhino has 4 legs";
            Skin = "Skin";
            Talk = "Talk";
            Eat = "Eats";
        }
        //return statement for method call
         public string RhinoUnique()
            {
                return "This animal has long horns on it's head.";
            }
        }
    }




    


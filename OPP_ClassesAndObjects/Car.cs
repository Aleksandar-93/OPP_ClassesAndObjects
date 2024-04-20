using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OPP_ClassesAndObjects
{
    internal class Car
    {
        //Member variable
        private string _name; //private field
        private int _hp;
        private string _color;
        public int _maxSpeed;

        //Read only and Write only property
        //if only want to get 
        // public int MaxSpeed { get; } = 10;

        // if only want to set
        public int MaxSpeed
        {
            set
            {
                _maxSpeed = value;
            }
        }

        // the public property
        public string Name { 
            get { return _name; } // get accessor 
            set { 
                if (value == "")
                {
                    _name = "Hello world Default Name";
                }
                else
                {
                    _name = value;
                }
            } // set accessor 
        }


        //Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 5;
            _color = "red";
            _maxSpeed = 150;
            Drive();
        }


        // Partial Specification constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = "red";
        }

        // Full specification constructor
        public Car(string name, int hp, string color = "black")
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
        }

        //Member methods
        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }

        public void Stop()
        {
            Console.WriteLine(_name + " stoped!");
        }
            
        public void Details()
        {
            Console.WriteLine("The car " + _name + " has " + _hp + " hp " + " it " + " color is " + _color );
        }
    }
}

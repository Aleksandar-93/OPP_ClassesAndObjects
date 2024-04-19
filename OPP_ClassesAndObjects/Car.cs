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
        // constructor
        public Car(string name, int hp = 0, string color = "black")
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

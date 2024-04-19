using OPP_ClassesAndObjects;

namespace ClassesAndObjects
{

    //A class in C# (and most other object-oriented programming languages)
    //is a blueprint for creating objects.
    //It defines a set of properties (data attributes)
    //and methods (functions) that an object of that class will have.
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.Drive();
            Car bmw = new Car();
            Console.WriteLine("press 1 to stop car!");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("car drives indefinetly");
            }
        }

    }
}

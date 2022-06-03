using System;

namespace ManejoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 170;
            int age = 25;
            string name = "Cristian Leiton";
            string information = "The requested info is:\n\nuser name: " + name
                + "\nuser age: " + age + "\nuser height: " + height + "\n\n\n";

            string informationInterpolation = $"(interpolation)The requested info is:\n\nuser name: {name}\nuser age: {age}\nuser height: {height}";

            Console.WriteLine(information);
            Console.WriteLine(informationInterpolation);
        }
    }
}


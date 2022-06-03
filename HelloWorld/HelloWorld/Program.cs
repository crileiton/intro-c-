using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? Please write your full name");
            string fullUserName = Console.ReadLine();
            Console.WriteLine("Hello " + fullUserName + ", Welcome to Platzi");
        }
    }
}


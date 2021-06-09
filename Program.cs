using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please identify yourself.");
            var name = Console.ReadLine();
            Console.WriteLine($"Greetings, {name}. Please state preferred customization options.");
            var setting = int.Parse(Console.ReadLine());
            Console.WriteLine("Default setting selected. Please stand by.");
            Console.WriteLine("*whimsical music plays*");
            Console.WriteLine("...");
            Console.WriteLine("*adorable figure appears*")


            Console.WriteLine($"How do you do, my {name}? Thank you for bringing me into the world. I am at your eternal service. Welcome to your new Pearl.");

           
        }
    }
}

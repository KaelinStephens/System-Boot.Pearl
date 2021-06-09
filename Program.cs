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
            var setting = Console.ReadLine();
            Console.WriteLine($"{setting} = Default setting selected. Please stand by...*whimsical music plays* .....*adorable figure appears* How do you do, my {name}? Thank you for bringing me into the world. I am at your eternal service. Welcome to your new Pearl.");

           
        }
    }
}

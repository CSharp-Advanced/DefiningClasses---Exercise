using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person rem = new Person()
            {
                Name = "Rem",
                Age = 25
            };
            Console.WriteLine($"{rem.Name} - {rem.Age}");

        }
    }
}

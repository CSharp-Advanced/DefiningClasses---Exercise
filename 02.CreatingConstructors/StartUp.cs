using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person noNameGuy = new Person();
            Console.WriteLine($"NoNameGuy: {noNameGuy.Name} - {noNameGuy.Age}");

            Person rem = new Person("Remzi", 25);
            Console.WriteLine($"{rem.Name} - {rem.Age}");

            Person years = new Person(21);
            Console.WriteLine($"Only years: {years.Age}");

        }
    }
}

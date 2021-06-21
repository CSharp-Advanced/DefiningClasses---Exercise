using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {

        }
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Can't be below 0");
                }
                this.age = value;
            }
        }
    }
}

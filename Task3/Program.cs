using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            people[0] = new Person { Age = 19, Name = "Elman" };
            people[1] = new Person { Age = 20, Name = "Cavid" };
            people[2] = new Person { Age = 21, Name = "Kamil" };

            int i = 0;

            while (i<people.Length)
            {
                Console.WriteLine($"{people[i].Name}-{people[i].Age} yash");
                i++;
            }
        }
    }

    class Person
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
    }
}

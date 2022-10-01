using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            people[0] = new Person { age = 19, firstname = "Elman" };
            people[1] = new Person { age = 20, firstname = "Cavid" };
            people[2] = new Person { age = 21, firstname = "Kamil" };

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Name: {people[i].firstname}  Age:{people[i].age}");
            }
        }
    }

    class Person
    {
        public int age;
        public string firstname;
    }
}

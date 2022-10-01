using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            people[0] = new Person(20,"Eldar");
            people[1] = new Person();
            people[2] = new Person(25, "Habil");

            Console.WriteLine(" ");

            foreach (var person in people)
            {
                person.ShowPerson();
            }
        }
    }

    class Person
    {
        private int age;
        private string name;

        public void ShowPerson()
        {
            Console.WriteLine($"{name}-{age} yash");
        }

        public Person()
        {
            name = "Orxan";
            age = 17;
            ShowPerson();
        }

        public Person(int Age, string Name)
        {
            age = Age;
            name = Name;
        }
    }
}

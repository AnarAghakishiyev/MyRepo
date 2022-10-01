using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();

            group.groupName = ".Net Developers(ELMA)";

            group.people = new Person[3];
            
            group.people[0] = new Person { a = 20, name = "Ramiz" };
            group.people[1] = new Person { a = 21, name = "Elsad" };
            group.people[2] = new Person { a = 22, name = "Nazim" };

            Console.WriteLine(group.groupName);

            foreach (var person in group.people)
            {
                Console.WriteLine($"Name: {person.name}  Age: {person.a} yash");
            }
        }
    }

    class Person
    {
        public int a;
        public string name;

    }

    class Group
    {
        public Person[] people;
        public string groupName;

    }
}

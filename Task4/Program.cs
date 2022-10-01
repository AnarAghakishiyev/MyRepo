using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Eldar");
            Person person2 = new Person("Orxan");

            person1.Age = 20;
            person2.Age = 21;

            Console.WriteLine(person1.ShowPerson());
            Console.WriteLine(person2.ShowPerson());
        }

        class Person
        {
            public Person(string Name)
            {
                name = Name;
            }
            private int age;
            private string name;

            public int Age
            {
                set { age = value; }
            }
            
            public string ShowPerson()
            {
                return $"{name}-{age} yash";
            }

        }
    }
}

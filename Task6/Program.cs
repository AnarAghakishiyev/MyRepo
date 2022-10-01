using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] people = new Person[3];

            people[0] = new Person(20, "Ugur");
            people[1] = new Person(21, "Afaq");
            people[2] = new Person(22, "Nuri");

            var group = new Group("ELMA", people);

            group.ShowGroup();
        }
    }

    class Person
    {
        public Person(int Age, string Name)
        {
            age = Age;
            name = Name;
        }
        private int age;
        private string name;

        public void ShowPerson()
        {
            Console.WriteLine($"Name:{name}  Age:{age}");
        }
    }

    class Group
    {
        public Group(string GroupName,Person[] People)
        {
            groupName = GroupName;
            people = People;
        }
        private string groupName;
        private Person[] people;

        public string GroupName 
        { 
            get { return groupName; }
            set { groupName = value; }
        }

        public void ShowGroup()
        {
            Console.WriteLine($"Group Name: {groupName}");
            Console.WriteLine("");
            Console.WriteLine("Group members");
            for (int i = 0; i < people.Length; i++)
            {
                people[i].ShowPerson();
            }
        }

    }
}

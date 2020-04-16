using System;
using Packt.Shared;

using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person harry = new Person { Name = "Harry" };
            Person mary = new Person { Name = "Mary" };
            Person jill = new Person { Name = "Jill" };

            Person baby1 = mary.ProcreateWith(harry);
            Person baby2 = Person.Procreate(harry, jill);
            Person baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            WriteLine("{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            );

            WriteLine($"5! is {Person.Factorial(5)}.");

            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}

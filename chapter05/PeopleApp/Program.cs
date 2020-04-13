using System;
using Packt.Shared;

using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1956, 12, 22);
            WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth
            );
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.HangingGardensOfBabylon;
            WriteLine(format: "{0}'s favourite wonder is {1}. It's integer is {2}.",
                arg0: bob.Name,
                arg1: bob.FavoriteAncientWonder,
                arg2: (int)bob.FavoriteAncientWonder
            );
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.StatusOfZeusAtOlympia;
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });
            WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            foreach (Person child in bob.Children)
            {
                WriteLine($" {child.Name}");
            }
            WriteLine($"{bob.Name} is a {Person.Species}");

            Person alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            WriteLine(format: "{0} was born on {1:dd MMM yy}",
                alice.Name,
                alice.DateOfBirth
            );

            BankAccount.InterestRate = 0.012M;
            BankAccount jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;
            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate
            );
            BankAccount gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;
            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: gerrierAccount.AccountName,
                arg1: gerrierAccount.Balance * BankAccount.InterestRate
            );
        }
    }
}

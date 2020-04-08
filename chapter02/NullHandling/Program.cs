#nullable enable

using System;

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // int thisCannotBeNull = 4;
            // thisCannotBeNull = null;
            int? thisCanBeNull = null;
            Console.WriteLine(thisCanBeNull);
            Console.WriteLine(thisCanBeNull.GetValueOrDefault());
            thisCanBeNull = 7;
            Console.WriteLine(thisCanBeNull);
            Console.WriteLine(thisCanBeNull.GetValueOrDefault());

            Address address = new Address();
            address.Building = null;
            address.Street = "Street";
            address.City = "London";
            address.Region = "Region";

            string? authorName = null;
            int x = authorName?.Length ?? 3;
            Console.WriteLine(x);

        }
    }
}

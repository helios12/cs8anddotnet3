using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] names;
            names = new string[4];
            names[0] = "Jack";
            names[1] = "Kate";
            names[2] = "Tom";
            names[3] = "Rebecca";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like a cat or a dog?");
            string userChoice = Convert.ToString(Console.ReadLine().ToLower());

            if (userChoice == "cat")
            {
                Console.WriteLine("You are a home-lover.");
            }
            else if (userChoice == "dog")
            {
                Console.WriteLine("You are a partygoer.");
            }
            else
            {
                Console.WriteLine($"You are a {userChoice} friend.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}

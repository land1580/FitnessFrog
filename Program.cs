using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fitness Frog");

            var runningTotal = 0.0;
            while (true)
            {
                //Prompt the user for mins exercised
                Console.WriteLine("");
                Console.Write("Please enter how many mins you exercised or type \"quit\" to exit: ");

                var entry = Console.ReadLine();
                if (entry.ToLower() == "quit")
                {
                    break;
                }

                try
                {
                    //Add mins exercised to total
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + "is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }
                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input.");
                    continue;
                }
                //Display total mins exercised to screen
                Console.WriteLine("Now you've exercised " + runningTotal + " total mins.");
                //Repeat until user quits
            }
            Console.WriteLine("");
            Console.WriteLine("Ok, Goodbye!");
            Console.WriteLine("Coded by: Lawrence Anderson");
        }
    }
}



using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Eternal Quest\n");

            GoalManager manager = new GoalManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Current score: {0}   (Level {1})\n", manager.Score, manager.Level);
                Console.WriteLine("Main Menu");
                Console.WriteLine(" 1. Create New Goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals to File");
                Console.WriteLine(" 4. Load Goals from File");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Display Score");
                Console.WriteLine(" 7. Quit");
                Console.Write("Select a choice (1‑7): ");

                string choice = Console.ReadLine() ?? string.Empty;
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        manager.CreateNewGoal();
                        break;
                    case "2":
                        manager.ListGoals();
                        break;
                    case "3":
                        manager.SaveGoals();
                        break;
                    case "4":
                        manager.LoadGoals();
                        break;
                    case "5":
                        manager.RecordEvent();
                        break;
                    case "6":
                        Console.WriteLine($"Your current score is {manager.Score} points.\n");
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 7.\n");
                        break;
                }
            }

            Console.WriteLine("Thanks for playing Eternal Quest. Keep striving!");
        }
    }
}
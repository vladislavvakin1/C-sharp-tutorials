using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = mainMenu();
            }
        }

        private static bool mainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Guess a number");
            Console.WriteLine("2) Jump a rope");
            Console.WriteLine("3) Exit");

            Console.WriteLine("Make your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    guessNumber();
                    return true;
                case "2":
                    jumpaRope();
                    Console.WriteLine();
                    Console.WriteLine("Wanna try something else? ");
                    string message = Console.ReadLine();
                    switch (message)
                    {
                        case "yes":
                            return true;
                        default:
                            return false;
                    }
                default:
                    return false;
            }

            //if (choice == "1")
            //{
                
            //}

            //else if (choice == "2")
            //{
                
            //}

            //else
            //{
                
            //}
           
        }

        private static void guessNumber()
        {
            Console.Clear();
            Console.WriteLine("Guess a number!");

            Random randInt = new Random();
            int randomNumber = randInt.Next(1, 11); 
            

            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();


                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong! ");
                }
            } while (incorrect == true);
            Console.WriteLine("Correct!");
        }

        private static void jumpaRope()
        {
            Console.Clear();
            Console.WriteLine("Jump a Rope!");
        }
    }
}
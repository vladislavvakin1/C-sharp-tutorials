using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a basic availiable staff
            string[] coffee = { "Robust Mexican", "Arabica from Algeria", "Soft Arabica from Pakistan", "Fresh Vietnamese Robust" };
            
            Hashtable table = new();
            table.Add(coffee[0], 1.5);
            table.Add(coffee[1], 2.5);
            table.Add(coffee[2], 1.7);
            table.Add(coffee[3], 2.0);

           
            Console.Clear();
            Console.WriteLine("Enter a secret code, please: ");
            string message = Console.ReadLine();

            //Cheking a guest to customize a respose
            CheckingALevelPermission();
            

            //a  fuction to catch a response
            bool  confirmationMessage(string messages)
            {
                if ((messages.Contains("Yes")) ||
                (messages.Contains("yes")) ||
                (messages.Contains("y")) ||
                (messages.Contains("Y")))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //function to check whether it is a member or not to correct prices.
            void CheckingALevelPermission()
            {
                if (message.Contains("membership"))
                {
                    Console.Clear();
                    Console.WriteLine("Your membership is confirmed!");

                    Console.Write("Would you like to add a new product? ");
                    string message1 = Console.ReadLine();

                    if (confirmationMessage(message1) == true)
                        AddCoffeeStaff();
                    else
                        printPrices();
                }
                else
                    printPrices();
            }



            void AddCoffeeStaff()
            {
                Console.Clear();
                Console.WriteLine("Please enter a name of a product: ");
                string name = Console.ReadLine();
                    
                Console.Clear();
                Console.WriteLine(name);
                Console.WriteLine("Please enter a price of the product: ");
                double price = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("You've added a {0} for {1:C}", name, price);
                table.Add(name, price);
                
                Console.WriteLine();
                Console.WriteLine("Would you like to add another product?");
                string response = Console.ReadLine();
                        
                if (confirmationMessage(response) == true)
                    AddCoffeeStaff();  
                else
                {
                    Console.Clear();
                    Console.WriteLine("Would you like to see what we have for you? ");
                    string response1 = Console.ReadLine();  
                    if (confirmationMessage(response1) == true)
                        printPrices();
                    else
                        Console.WriteLine("See you later!");
                }
            }



            void printPrices()
            {
                Console.Clear();
                Console.WriteLine("We invite you to check our current prices for our products!");
                Console.WriteLine();
                if (message.Contains("membership"))
                {
                    foreach (DictionaryEntry product in table)
                        Console.WriteLine("{0} for {1:C}", product.Key, Convert.ToDouble(product.Value) * 0.5);
                }
                else
                {
                    foreach (DictionaryEntry product in table)
                        Console.WriteLine("{0} for {1:C}", product.Key, product.Value);
                }

            }
            
            

        }

        

    }

    
}


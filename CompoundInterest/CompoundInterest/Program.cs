using System;
using System.Collections;


namespace CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter amount of money you've landed: ");
            string amount = Console.ReadLine();
            double amount_ = Convert.ToDouble(amount);
            double amount1 = amount_;

            Console.WriteLine("Please enter your monthly interest: ");
            string interest = Console.ReadLine();
            double interest_ = Convert.ToDouble(interest);

            Console.WriteLine("Please enter time period in months: ");
            string time = Console.ReadLine();
            int month_ = Int32.Parse(time);
            double result = CompoundInterest(amount_, interest_, month_);

            Console.WriteLine($"Your total interest from {amount1} under {interest}% in {time} month will be {result}.");
            Console.WriteLine("That's not that bad...");

            double CompoundInterest(double amount_, double interest_, int time_)
            {
                
                for (int i = 0; i < time_; i++)
                {
                    double monthlyInterest = amount_ * interest_ / 100;
                    amount_ += monthlyInterest;
                }
                double totalInterest = amount_ - amount1;
                return totalInterest;
                
            }
            
                
            
        }
    }
}
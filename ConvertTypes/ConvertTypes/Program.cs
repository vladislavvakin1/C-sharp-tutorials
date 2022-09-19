using System;

namespace ConvertingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ex1 = true;
            bool ex2 = false;
            bool ex3 = 1 > 2;

            Console.WriteLine(ConvertBoolToString(ex1));
            Console.WriteLine(ConvertBoolToString(ex2));
            Console.WriteLine(ConvertBoolToString(ex3));

            string ConvertBoolToString(bool message)
            {
                string newMessage = message.ToString();
                return newMessage;
            }

            string message = "Hi there! You have a shift tomorrow!";
            Char[] StringToChar(string message)
            {
                
                return message.ToCharArray();
            }
            foreach (char c in StringToChar(message))
            {
                Console.Write(c);
            }
        }
    }

}

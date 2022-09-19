using System;
using System.Net;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string text = "A class is the most powerfull data type in C#. Like a structure,  " +
                            "a class defines the data and behavior of the data type. ";*/


            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            Console.WriteLine(reply);
            System.IO.File.WriteAllText(@"C:\user-vladislav\all_folders\Writetext.txt", reply);
        }
    }
}
//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System;

namespace PrincipleSegregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to, my project");
                Console.WriteLine("1. Amazon ");
                Console.WriteLine("2. Digital Ocean ");

                Console.Write("Enter your command(1 or 2): ");
                string command = Console.ReadLine();

                if (command.Contains("1") is true)
                {
                    Amazon amazon = new Amazon();

                    Console.Clear();
                    Console.WriteLine("== Amazon ==");
                    Console.WriteLine("1. Create Serve");
                    Console.WriteLine("2. Get CDN Adress");
                    Console.WriteLine("3. Get File");
                    Console.WriteLine("4. List Servers");
                    Console.WriteLine("5. Store File");

                    Console.Write("Enter your command(1, 2...): ");
                    string commandAmazon = Console.ReadLine();

                    switch (commandAmazon)
                    {
                        case "1":
                            amazon.CreateServer("Uzbekistan");
                            break;
                        case "2":
                            amazon.GetCDNAdress();
                            break;
                        case "3":
                            amazon.GetFile("Path name");
                            break;
                        case "4":
                            amazon.ListServers("List");
                            break;
                        case "5":
                            amazon.StoreFile("Fayl");
                            break;
                    }
                }

                if (command.Contains("2") is true)
                {
                    DigitalOcean digitalOcean = new DigitalOcean();

                    Console.Clear();
                    Console.WriteLine("== Digital Ocean ==");
                    Console.WriteLine("1. Store File");
                    Console.WriteLine("2. Get File");

                    Console.Write("Enter your command(1, 2...): ");
                    string commandDigitOcean = Console.ReadLine();

                    switch (commandDigitOcean)
                    {
                        case "1":
                            digitalOcean.StoreFile("Fayl");
                            break;
                        case "2":
                            digitalOcean.GetFile("Path name");
                            break;
                    }
                }

                Console.Write("Is continue(no or yes): ");
                string isContinueCommand = Console.ReadLine();

                if (isContinueCommand.ToLower().Contains("no") is true)
                {
                    isContinue = false;
                }
            } while (isContinue is true);
            
        }
    }
}

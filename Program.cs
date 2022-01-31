using System;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Ticketing_System_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do ?");
            Console.WriteLine("1: Read from the file.");
            Console.WriteLine("2: Write to the file.");
            Console.WriteLine("3: Enter any key to exit.");
            var menuSelection = Convert.ToInt32(Console.ReadLine());
            //file

            string file = "data.txt";
            while (menuSelection == 1)
            {
                
                
                //read from file
                StreamReader sr = new StreamReader(file);
                
                string line = sr.ReadLine();

                

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    var column = line.Split(',');
                    var sv = string.Join(',', column);
                    Console.WriteLine(sv); 
                    
                    
                }  sr.Close();
                Console.WriteLine("What would you like to do ?");
                Console.WriteLine("1: Read from the file.");
                Console.WriteLine("2: Write to the file.");
                Console.WriteLine("3: Enter any key to exit.");
                menuSelection = Convert.ToInt32(Console.ReadLine());
            }
            //prompt for data entry
            while (menuSelection == 2){
                Console.WriteLine("What is your ticket ID ?");
                var ticketID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is this ticket about ?");
                var ticketDescription = Console.ReadLine();

                Console.WriteLine("Your ticket will be marked as open...");
                var ticketStatus = "open";

                Console.WriteLine("What is this ticket priority ?");
                var ticketPriority = Console.ReadLine();

                Console.WriteLine("Who is submitting this ticket ?");
                var ticketSubmitter = Console.ReadLine();

                Console.WriteLine("Who is assigned to this ticket ?");
                var ticketAssignee = Console.ReadLine();

                Console.WriteLine("How many are watching ?");
                var numberWatching = Convert.ToInt32(Console.ReadLine());
                string[] viewerNames = new string[numberWatching];

                Console.WriteLine("Who is watching ?");

                //loop for multiple people
                for (int i = 0; i < numberWatching; i++)
                {
                    Console.WriteLine("Person (" + (i + 1) + ")");
                    var who = Console.ReadLine();
                    viewerNames[i] = who;

                
                }//Console.WriteLine(ticketID + ticketDescription + ticketStatus + ticketPriority + ticketSubmitter + ticketAssignee + viewerNames);
                
                //var whoIsIt = viewerNames;
                var ss = string.Join('|', viewerNames);
                var se = string.Join(',', ticketID , ticketDescription, ticketStatus, ticketPriority, ticketSubmitter, ticketAssignee, ss);
                
                    StreamWriter sw = new StreamWriter(file, append: true);
                var dataLine = (se);
                sw.WriteLineAsync(dataLine);
                sw.Close();

                Console.WriteLine("What would you like to do ?");
                Console.WriteLine("1: Read from the file.");
                Console.WriteLine("2: Write to the file.");
                Console.WriteLine("3: Enter any key to exit.");
                menuSelection = Convert.ToInt32(Console.ReadLine());
            } if ((menuSelection != 2) || (menuSelection != 1))
            {
                Console.WriteLine("What would you like to do ?");
            Console.WriteLine("1: Read from the file.");
            Console.WriteLine("2: Write to the file.");
            Console.WriteLine("3: Enter any key to exit.");
            menuSelection = Convert.ToInt32(Console.ReadLine());
            }
            
            //write to file





            //Console.WriteLine("This is who is watching: ");
            // for (int i = 0; i < numberWatching; i++)
            // {
            //    Console.WriteLine(viewerNames[i]);
            //}









        }
    }
}

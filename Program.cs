﻿using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace clubMemberIndexer
{
    internal class Program
    {

        public const int Size = 15;  // global variable
    class ClubMembers
    {
        private string[] Members = new string[Size];
        public string ClubType { get; set; } 
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }

                ClubType = string.Empty; 
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

        //indexer get and set methods

            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index<= Size -1)
                    {
                        tmp = Members[index];
                    }

                    else
                    {
                        tmp = "";
                    }
                    return tmp;
                }
                set { 
                if (index >= 0 && index <= Size-1)
                    {
                        Members[index] = value;
                    }
            }
            }
        }


    
        static void Main(string[] args)
        {
            ClubMembers Club = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which person do you want to enter (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1 - {Size}");
                }

                Console.WriteLine("Enter the members of the club");
                Club[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop == "q")
                    end = true;

            }
            Console.WriteLine("What is the club type?");
            Club.ClubType = Console.ReadLine();
            Console.WriteLine("What is the club location?");
            Club.ClubLocation = Console.ReadLine();
            Console.WriteLine("What is the meeting date?");
            Club.MeetingDate = Console.ReadLine();

            Console.WriteLine($"Here is information for the clubs");
            Console.WriteLine($"Members");
            for (int i = 0; i < Size; i++)
            {
                if (Club[i] != string.Empty)
                    Console.WriteLine(Club[i]);
              
            }

            Console.WriteLine($"Club Type: {Club.ClubType}");
            Console.WriteLine($"Location: {Club.ClubLocation}");
            Console.WriteLine($"Date: {Club.MeetingDate}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace TrainingRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> participants = new List<Person>();

            while (true)
            {
                Console.WriteLine("===== Training Registration System =====");
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. Register Teacher");
                Console.WriteLine("3. Register General Person");
                Console.WriteLine("4. Show All Participants");
                Console.WriteLine("0. Exit");
                Console.Write("Select: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Student s = new Student();
                        s.Register();
                        participants.Add(s);
                        break;

                    case "2":
                        Teacher t = new Teacher();
                        t.Register();
                        participants.Add(t);
                        break;

                    case "3":
                        GeneralPerson g = new GeneralPerson();
                        g.Register();
                        participants.Add(g);
                        break;

                    case "4":
                        Console.WriteLine("=== Participant List ===");
                        foreach (Person p in participants)
                        {
                            p.DisplayInfo();
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
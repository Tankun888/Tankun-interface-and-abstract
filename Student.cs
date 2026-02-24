using System;

namespace TrainingRegistration
{
    public class Student : Person
    {
        public string StudentID { get; set; }

        public override void Register()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Student ID: ");
            StudentID = Console.ReadLine();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Student] Name: {Name}, Age: {Age}, ID: {StudentID}");
        }
    }
}
using System;

namespace TrainingRegistration
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override void Register()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject: ");
            Subject = Console.ReadLine();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Teacher] Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
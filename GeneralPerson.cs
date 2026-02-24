using System;
using System.Xml.Linq;

namespace TrainingRegistration
{
    public class GeneralPerson : Person
    {
        public override void Register()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[General] Name: {Name}, Age: {Age}");
        }
    }
}
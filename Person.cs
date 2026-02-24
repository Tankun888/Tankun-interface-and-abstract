using System;

namespace TrainingRegistration
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Register();
        public abstract void DisplayInfo();
    }
}
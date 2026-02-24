## 📊 Class Diagram (Mermaid)

```mermaid
classDiagram

class Person {
    <<abstract>>
    +string FirstName
    +string LastName
    +string Phone
    +string Email
    +Register()
    +DisplayInfo()
}

class IRegistrable {
    <<interface>>
    +RegisterTraining()
}

class ITrainer {
    <<interface>>
    +ConductTraining()
    +ApproveResult()
}

class Student {
    +string Major
    +string StudentID
}

class Teacher {
    +string Major
    +string AcademicPosition
}

class GeneralPerson {
    +string Workplace
    +string Position
}

Person <|-- Student
Person <|-- Teacher
Person <|-- GeneralPerson

IRegistrable <|.. Student
IRegistrable <|.. Teacher
IRegistrable <|.. GeneralPerson

ITrainer <|.. Teacher
ITrainer <|.. GeneralPerson

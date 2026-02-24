เเทนคุณ ทันเขิม 683450064-0 

## 📊 Class Diagram (Mermaid)

```mermaid
classDiagram

class Person {
    <<abstract>>
    -string FirstName
    -string LastName
    -string Phone
    -string Email
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
    -string Major
    -string StudentID
    +RegisterTraining()
}

class Teacher {
    -string Major
    -string AcademicPosition
    +RegisterTraining()
    +ConductTraining()
    +ApproveResult()
}

class GeneralPerson {
    -string Workplace
    -string Position
    +RegisterTraining()
    +ConductTraining()
    +ApproveResult()
}

Person <|-- Student
Person <|-- Teacher
Person <|-- GeneralPerson

IRegistrable <|.. Student
IRegistrable <|.. Teacher
IRegistrable <|.. GeneralPerson

ITrainer <|.. Teacher
ITrainer <|.. GeneralPerson

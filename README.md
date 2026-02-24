classDiagram

class Person {
    <<abstract>>
    -string firstname
    -string lastname
    -string phone
    -string email
    +Register()
    +ShowInfo()
}

class IRegister {
    <<interface>>
    +Register()
}

class ITrainer {
    <<interface>>
    +Teach()
    +ApproveResult()
}

class Student {
    -string studentId
    -string major
    +Register()
    +ShowInfo()
}

class Teacher {
    -string major
    -string academicPosition
    +Register()
    +ShowInfo()
    +Teach()
    +ApproveResult()
}

class GeneralPerson {
    -string workplace
    -string position
    +Register()
    +ShowInfo()
    +Teach()
    +ApproveResult()
}

Person <|-- Student
Person <|-- Teacher
Person <|-- GeneralPerson

IRegister <|.. Student
IRegister <|.. Teacher
IRegister <|.. GeneralPerson

ITrainer <|.. Teacher
ITrainer <|.. GeneralPerson

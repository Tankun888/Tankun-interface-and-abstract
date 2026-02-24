# Training Registration System

## 📖 Project Description

ระบบลงทะเบียนอบรมที่รองรับบุคคล 4 ประเภท ได้แก่

- นักศึกษา (Student)
- อาจารย์ (Teacher)
- บุคคลทั่วไป (GeneralPerson)
- วิทยากร (Trainer Role)

ระบบสามารถ:
- เพิ่มข้อมูลผู้เข้าอบรม
- เพิ่มข้อมูลวิทยากร
- แสดงรายชื่อผู้เข้าอบรม
- แสดงรายชื่อวิทยากร

---

## 🏗 Object-Oriented Design

โครงสร้างระบบออกแบบตามหลัก OOP โดยใช้

- Abstract Class
- Interface
- Inheritance
- Polymorphism

---

## 🔹 Class Structure

### 1️⃣ Abstract Class

**Person**
- FirstName
- LastName
- Phone
- Email
- DisplayInfo()
- Register()

---

### 2️⃣ Interface

**IRegistrable**
- RegisterTraining()

**ITrainer**
- ConductTraining()
- ApproveResult()

---

### 3️⃣ Classes

**Student**
- Major
- StudentID
- implements IRegistrable

**Teacher**
- Major
- AcademicPosition
- implements IRegistrable
- implements ITrainer

**GeneralPerson**
- Workplace
- Position
- implements IRegistrable
- implements ITrainer

---

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

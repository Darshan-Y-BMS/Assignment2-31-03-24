using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SiemensAssignment2
{
    //Exercise 1:  Shape Hierarchy
    //Create a class hierarchy for different shapes.
    //The base class is Shape, and it has a method
    //CalculateArea().Derive two classes, Circle and Rectangle, and 
    //override the CalculateArea() method for each shape.
    
    //Exercise 2: Animal Kingdom
    //Create a class hierarchy for animals.The base class is Animal, and it has methods
    //like MakeSound() and Move(). Derive two classes, Lion and Fish,
    //and override the methods for each animal type.
    
    //Exercise 3: Employee Hierarchy
    //Design a class hierarchy for employees in a company.The base class is Employee,
    //and it has properties like Name, EmployeeId, and Salary.Derive two subclasses,
    //Manager and Developer.Managers should have an additional property for Department,
    //and Developers for ProgrammingLanguage.Implement a method to calculate
    //the bonus for each type of employee
    
    //Exercise 4: Online Shop
    //Create a class hierarchy for an online shopping system.The base class is Product,
    //and it has properties like ProductId, ProductName, and Price.Derive two classes,
    //PhysicalProduct for physical items and DigitalProduct for digital items.
    //Include methods to calculate the shipping cost for physical products and
    //display a download link for digital products.
   
    //Exercise 5: Vehicle Rental System
    //Design a class hierarchy for a vehicle rental system.The base class is Vehicle, and
    //it has properties like Make, Model, and Year.Derive two classes, Car and Motorcycle.
    //Each derived class should have additional properties and methods specific to the vehicle type.
    
    //Exercise 6: Drawing Shapes
    //Create a program that simulates drawing graphic shapes.Design a base class Shape with
    //properties like X, Y, and methods for drawing the shape.Derive two classes, Circle and
    //Square.Each derived class should have additional properties and methods specific to the shape.
    
    //Exercise 7: Banking System
    //Create a class hierarchy for a banking system.Design a base class Account with properties like AccountNumber,
    //AccountHolder, and Balance.Derive two classes, SavingsAccount and CheckingAccount.Implement methods
    //for deposit, withdrawal, and interest calculation for savings accounts.Checking accounts should have
    //methods for overdraft protection.

    //Exercise 8: School System
    //Design a class hierarchy for a school system.The base class is Person with properties like Name and Age.
    //Derive two classes, Student and Teacher.Include methods or properties specific to each type,
    //like a Grade property for students or a list of SubjectsTaught for teachers.
    internal class Program
    {
        public void Exercise1()
        {
            Console.WriteLine("Printing area of Circle and Reactangle\n");
            Circle c = new Circle(10);
            Rectangle r = new Rectangle(4, 5);

            //Circle area
            c.CalculateArea();
            c.ShowArea();
            //Recatangle area
            r.CalculateArea();
            r.ShowArea();
        }
        public void Exercise2()
        {
            Console.WriteLine("Printing sound and motion of Lion and Fish\n");

            Lion l = new Lion();
            Fish f = new Fish();
            l.MakeSound();
            l.Move();
            f.MakeSound();
            f.Move();

        }
        public void Exercise3()
        {
            Manager m = new Manager("Siemen", "IMSD2232", 450000, "DTS");
            Developer d = new Developer("Darshan", "1BM21IS", 50000, "C Sharp");


            Console.WriteLine("Details of a Manager");
            m.GetDetails();
            m.GetBonus();

            Console.WriteLine("\n\nDetails of a Developer");
            d.GetDetails();
            d.GetBonus();
        }
        public void Exercise4()
        {
            DigitalProduct d = new DigitalProduct("UIIXS324N231", "Notepad", 10000,"https://xyz.com");
            PhysicalProduct p = new PhysicalProduct("UIIXS324N233", "Laptop", 120000);
            Console.WriteLine("DETAILS OF DEGITAL PRODUCT\n");
            d.GetProduct();
            Console.WriteLine("\n\nDETAILS OF PHYSICAL PRODUCT\n");
            p.GetProduct();
        }
        public void Exercise5()
        {

            Vehicle v = new Vehicle("1", "1", 2009);
            Car c = new Car("TATA", "Nano", 2011, "Dieasel");
            Motorcycle m = new Motorcycle("HERO HONDA", "Z3 series", 2012, "Petrol");

            c.show();
            m.show();

        }
        public void Exercise6()
        {
            Circles c = new Circles(2, 3, 6);
            c.drawShape();
            Square s = new Square(2, 3, 10);
            s.drawShape();
        }
        public void Exercise7()
        {
            SavingsAccount s = new SavingsAccount("1002230223", "Darshan", 120033, 4);
            CheckingAccount c = new CheckingAccount("1002230443", "Ganesh", 20000, 500);
            //s.ShowBalance();
            //s.withdrawal();
            c.ShowBalance();
            c.withdraw();
        }
        public void Exercise8()
        {
            string[] subject = new string[] { "Kannada", "English", "C#", "CS" };

            Teacher t = new Teacher("Radhika", 54, subject);
            Student s = new Student("Suhas", 12, 'A');

            Console.WriteLine("\nTeacher Details");
            t.getDetails();
            Console.WriteLine("\n\nStudent Details");
            s.getDetails();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Exercise1();
            //p.Exercise2();
            //p.Exercise3();
            //p.Exercise4();
            //p.Exercise5();
            //p.Exercise6();
            //p.Exercise7();
            //p.Exercise8();
            Console.ReadKey();
        }


    }
}

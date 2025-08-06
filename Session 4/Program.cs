using Session_4.Part_01_Class;
using System;

namespace Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to
            //Accept two integers and return their sum.
            //Accept three integers and return their sum.
            //Accept two doubles and return their sum.
            //Calculator calculator = new Calculator();
            //Console.WriteLine("Sum of 2 integers: " + calculator.Add(5, 10));
            //Console.WriteLine("Sum of 3 integers: " + calculator.Add(5, 10, 15));
            //Console.WriteLine("Sum of 2 doubles: " + calculator.Add(5.5, 10.5));

            #endregion

            #region Q2) Create a class named Rectangle with the following constructors
            //A parameterless constructor that sets the width and height to 0.
            //A constructor that accepts width and height as integers.
            //A constructor that accepts a single integer and sets both width and height to that value.

            //Rectangle rectangle1 = new Rectangle();
            //Console.WriteLine($"Rectangle 1:\n Width: {rectangle1.Width}, Height: {rectangle1.Height}");
            //Rectangle rectangle2 = new Rectangle(5, 10);
            //Console.WriteLine($"Rectangle 2\n Width: {rectangle2.Width}, Height: {rectangle2.Height}");
            //Rectangle rectangle3 = new Rectangle(7);
            //Console.WriteLine($"Rectangle 3\n Width: {rectangle3.Width}, Height: {rectangle3.Height}");

            #endregion

            #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts
            //*Note: Overload the +, - operator to add and subtract two complex numbers.
            //Complex complex1 = new Complex { Real = 3, Img = 4 };
            //Complex complex2 = new Complex { Real = 1, Img = 2 };
            //Complex sum = complex1 + complex2;
            //Complex difference = complex1 - complex2;
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Subtract : {difference}");

            #endregion

            #region Question 4)

            #region a) Create a base class named Employee with method That Work as it prints "Employee is  working"
            //Employee employee = new Employee();
            //employee.EmpName = "Mohamed Tarek";
            //employee.EmpAge = 21;
            //employee.EmpSalary = 50000;
            //Console.WriteLine(employee.Work());
            //Console.WriteLine(employee);

            #endregion

            //Console.WriteLine("==============================================");

            #region b) Create a derived class named Manager that overrides the Work method to print "Manager is managing"
            //*Ensure that the Manager class also calls the Work method of the Employee class within its  Overridden method
            //Manager manager = new Manager();
            //manager.ManagerName = "Mido Tarek";
            //manager.ManagerAge = 21;
            //manager.ManagerSalary = 80000;
            //Console.WriteLine(manager.Work());
            //Console.WriteLine(manager);


            #endregion

            #endregion

            #region Question 5)

            #region a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass"
            //BaseClass baseClass = new BaseClass();
            //Console.WriteLine(baseClass.DisplayMessage());
            //Console.WriteLine("==============================");

            #endregion

            #region b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword
            //DerivedClass1 derivedClass1 = new DerivedClass1();
            //Console.WriteLine(derivedClass1.DisplayMessage());
            //Console.WriteLine("==============================");

            #endregion

            #region C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword
            //DerivedClass2 derivedClass2 = new DerivedClass2();
            //Console.WriteLine(derivedClass2.DisplayMessage());

            #endregion

            //Then explain the difference between using override and new (using binding behavior)

            #endregion

            #endregion
        }
    }
}

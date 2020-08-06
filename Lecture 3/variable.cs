using System;
/*
    Sample Class for Lecture - 3
    Date: 31-07-2020
*/
/*
    - unique
    - case sensative 
    - naming convention
        - char f // valid but not a good approach
        - int m = 60 --->  int mintuesPerHour = 60
    - letter, digits and _  // int minutes_Per_Hour = 60
    - begin with letter not begin with digit
    - do not use reserved words eg int double async for 
        // intRollNo 
    int g      -- valid but not a good approach
    char 1love  -- invalid
    string first_name -- valid
    int static -- invalid
    myName and myname are different
*/
namespace Sample 
{
    class SampleClass
    {
        // This is the Main Method
        static void Main(string[] args)
        {
            // data-type variableName = value 
            string name = "Santosh GC";
            // string name = "Shree Krishna"; //A local variable named 'name' is already defined in this scope
            int roll = 45;
            const float PI = 3.1415F;
            double grade = 3.6589D;
            bool status = true;
            char firstLetter = name[0]; // char firstLetter = 'S'
            // PI = 4.15F; // this is illegal because we cannot change constant
            Console.Write("Student Name: ");
            Console.WriteLine(name);

            Console.Write("Student Roll: ");
            Console.WriteLine(roll);

            Console.Write("Student Status: ");
            Console.WriteLine(status);

            Console.Write("Value of PI: ");
            Console.WriteLine(PI);

            Console.Write("Grade : ");
            Console.WriteLine(grade);

            Console.Write("Student Code: ");
            Console.WriteLine(firstLetter);
        }
    }
}

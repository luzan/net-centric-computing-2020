using System;
/*
    User Input
    Console.ReadLine() // System.Console.ReadLine() 
    - return string
    - required place ma type conversion use
*/
namespace Sample 
{
    class SampleClass
    {
        // This is the Main Method
        static void Main(string[] args)
        {
            string studentName;
            int rollNumber;

            Console.WriteLine("Enter your name: ");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter your Roll: ");
            // rollNumber = Console.ReadLine();
            // Cannot implicitly convert type  'string' to 'int'
            rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name : " + studentName);        
            Console.WriteLine("Roll no.: " + rollNumber);  
        }
    }
}

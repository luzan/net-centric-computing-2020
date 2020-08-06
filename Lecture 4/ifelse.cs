using System;
/*
    if
    else
    else if
    switch

    < <= > >= == !=

    // Display Division by Percentage
        - Take user input of percentage in integer value
        - check using if else if structure
*/
namespace Sample 
{
    class IfElseDemoClass
    {
        static void Main(string[] args)
        {

            int percentageOne = 50;
            int percentageTwo = 60;
            int percentageThree = 55;
            if(percentageOne > percentageTwo) { // enters this block only when the condition is true
                Console.WriteLine("Percentage One is Greater than two");
            } else if (percentageOne > percentageThree) {
                Console.WriteLine("Percentage One is Greater than three");
            } else {
                Console.WriteLine("Percentage Two is Greater");
            }

            int time = 20; // 24hr clock
            // if ( time < 18) {
            //     Console.WriteLine("Good Day!");
            // } else {
            //     Console.WriteLine("Good Evening!");
            // }

            // Ternary Operator 
            // variable = (condition) ? expressionTrue : expressionFalse;

            string result = (time < 18) ? "Good Day!" : "Good Evening!";
            Console.WriteLine(result);
        }
    }
}

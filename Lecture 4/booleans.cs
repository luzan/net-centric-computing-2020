using System;
/*
    YES / NO
    ON / OFF
    TRUE / FALSE
*/
namespace Sample 
{
    class BooleanDemoClass
    {
        static void Main(string[] args)
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            Console.WriteLine(10 == 9); // returns False, because 10 is higher than 9

        }
    }
}

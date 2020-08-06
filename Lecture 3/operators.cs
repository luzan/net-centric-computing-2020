using System;
/*
    Operators
    - Arithmetic Operators
        + - * / % ++ --
    - Assignment 
        = += -= *= /= %= &= |= ^= >>= <<=
        x += 5 
        x = x + 5
    - Comparision Operator
        == != > < >= <=
    - Logical Operator
        && || !

    Assignment 
    + / -= == &&
    
    luzan.baral@sochcollege.edu.np
*/
namespace Sample 
{
    class SampleClass
    {
        // This is the Main Method
        static void Main(string[] args)
        {
            int firstNumber = 8;
            int secondNumber = 28;

            int thirdNumber = secondNumber - firstNumber;
            Console.WriteLine(thirdNumber);

            thirdNumber -= 6; // thirdNumber = 20 - 6
            Console.WriteLine(thirdNumber);
        }
    }
}

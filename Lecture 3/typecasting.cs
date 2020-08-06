using System;
/*
    Type Casting

    Implicit Casting (automatically) - converting a smaller type to a larger type size
    char -> int -> long -> float -> double

    Explicit Casting (manually) - converting a larger type to a smaller size type
    double -> float -> long -> int -> char

    Type Conversion Methods
    Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):
*/
namespace Sample 
{
    class SampleClass
    {
        // This is the Main Method
        static void Main(string[] args)
        {
           
           double myDoubleAge = 20.55;
           int myAge = (int) myDoubleAge;
           bool myBool = true;
            /*
             case int myAge = myDoubleAge;
            Cannot implicitly convert
            type 'double' to 'int'. An explicit conversion exists
            (are you missing a cast?)
            */
           Console.WriteLine(myAge);
           Console.WriteLine(myDoubleAge);
           Console.WriteLine(Convert.ToString(myBool));
        }
    }
}

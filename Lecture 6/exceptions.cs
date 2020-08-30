/*
using System.Exception

try, catch, finally, throw

try {
   // statements causing exception
   // network connectivity
   // input/output 
   // filehandling
} catch( ExceptionName e1 ) { //network failure
   // error handling code
} catch( ExceptionName e2 ) {
   // error handling code
} catch( ExceptionName eN ) {
   // error handling code
} finally {
   // statements to be executed
}

System.IO.IOException
System.ArrayTypeMismatchException
System.DivideByZeroException
System.OutOfMemoryException
*/

using System;

namespace ErrorHandlingApplication {
    class DivNumbers {
        int result;
        DivNumbers() {
            result = 0;
        }
        public void division( int num1, int num2) {
            try {
                result = num1 / num2; // 50 / 0
            } catch (DivideByZeroException e) {
                Console.WriteLine(e);
            } finally {
                Console.WriteLine("Result = " + result);
            }            
        }

        static void Main(string[] args) {
            DivNumbers d = new DivNumbers();
            d.division(50 , 0);
            Console.ReadKey();
        }
    }
}
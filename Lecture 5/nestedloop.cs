using System;
/*
    Outer-Loop // 0 - 3
    {
        // body of outer-loop
        Inner-Loop // 0 -5 
        {
            // body of inner-loop
        }
     ... ... ...
    }
*/
namespace Sample 
{
    class NestedLoopDemoClass
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5};
            string[] names = {"Santosh", "Sujana", "Shree", "Aashish", "Sufi"};

            // accessing values of array using loop
            for(int i = 0; i < numbers.Length; i++){  
                Console.WriteLine("Student's Roll number = {0}, Name = {1}", numbers[i], names[i]);
            }

            // nested loop example
            int outerLoop = 0, innerLoop = 0;
            for(int i = 1; i<=5; i++){
                outerLoop++;
                for(int j = 1; j <= 5; j++){
                    innerLoop++;
                }
            }
            Console.WriteLine("Outer loop runs {0} times", outerLoop);
            Console.WriteLine("Inner loop runs {0} times", innerLoop);
            Console.WriteLine();

            // printing pattern using nested loop.
            /*
            i   output
            1   1
            2   1 2
            3   1 2 3
            4   1 2 3 4
            5   1 2 3 4 5
            */
            for(int i=1; i<=5; i++){
                // 3
                for(int j=1; j<=i; j++){ // 4
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

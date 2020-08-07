using System;

namespace Sample 
{
    class ArrayDemoClass
    {
        static void Main()
        {
            int[] numbers = {1,2,3,4,5};
            string[] names = {"Santosh", "Sujana", "Shree", "Aashish", "Sufi"}; // length = 5 // names[5] -- array out of bound index
            names[0] = "Roshan";
            // array's index starts from 0
            // and ends at array's length - 1
            // [0]
            Console.WriteLine(numbers[1] + " " + names[1]);
            Console.WriteLine(numbers.Length);
        }
    }
}

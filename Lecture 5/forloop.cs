using System;
/*
    for (initialization; condition; iterator)
    {
        // body of for loop
    }
*/
namespace Sample 
{
    class ForDemoClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number to add? ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number; i++) {
                sum += i;
            }
            Console.WriteLine("Sum of first {0} natural numbers = {1}", number, sum);
        }
    }
}

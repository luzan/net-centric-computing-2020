using System;
/*
    while (test-expression)
    {
        // body of while
    }
    
    While loop execution steps		
Iteration	Value of i	i<=5     Value of sum
1           1           true    1
2           2           true    3
3           3           true    6
4           4           true    10
5           5           true    15
6           6           false   loop terminate
*/
namespace Sample 
{
    class WhileDemoClass
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;
            while(i <= 5) {
                sum += i; // sum = sum + i;
                // 1 = 1 + 2 = 3 + 3 = 6 + 4 = 10 + 5 = 15
                i++;
            } 
            Console.WriteLine("Value of sum = " + sum);
        }
    }
}

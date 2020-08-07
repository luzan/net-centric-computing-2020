using System;
/*
    foreach (element in iterable-item)
    {
        // body of foreach loop
    }
*/
namespace Sample 
{
    class ForEachDemoClass
    {
        static void Main(string[] args)
        {
            string[] names = {"Santosh", "Sujana", "Shree", "Aashish", "Sufi"};
            foreach(string name in names){
                Console.WriteLine(name);
            }
        }
    }
}

using System;
// string is a collection of characters
/* 
    Escape Character
    ' Single Quote  \'
    " Double Quote  \"
    \ Backslash     \\

    \n newline
    \t tab
    \b backspace
*/
namespace Sample 
{
    class StringDemoClass
    {
        static void Main()
        {
            string greeting = "Hello \"Good Morning\" Soch";
            string name = "Namaste";

            Console.WriteLine(greeting);

            Console.WriteLine("The length of the greeting string is: " + greeting.Length);

            Console.WriteLine(greeting.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(greeting.ToLower());   // Outputs "hello world"

            // string final = greeting + name;
            string final = string.Concat(greeting, name); // Hello SochNamaste
            Console.WriteLine(final);

            // String Interpolation
            // string another = $"I want to say {greeting} {name}";
            // I want to say Hello Soch Namaste
            // Console.WriteLine(another);

            Console.WriteLine(greeting[0]);

            // IndexOf()
            int indexOfS = greeting.IndexOf("S");

            // Substring()
            Console.WriteLine(greeting.Substring(indexOfS));

            // " ' \
        }
    }
}

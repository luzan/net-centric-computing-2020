using System;

namespace Sample 
{
    class SampleClass
    {
        static void Main(string[] args)
        {
            for( int i=1; i<=100; ++i ){
                bool modThree = ( i % 3 == 0 ? true : false );
                bool modFive = ( i % 5 == 0 ? true : false );
                if( !modThree && !modFive ){
                    Console.Write(i + ", ");
                }else{
                    if(modThree && modFive) {
                        Console.Write("KaleGore, ");
                    } else {
                        if( modThree ) Console.Write("Kale, ");
                        if( modFive ) Console.Write("Gore, ");
                    }               
                }
            }
        }
    }
}

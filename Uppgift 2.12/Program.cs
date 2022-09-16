using System;


 namespace Uppgift_2._12
 {
    class program
    {
        static void Main(string[] args)
        {
            int avgift = 300;
            Console.WriteLine("Hur många dagar ska du hyra den här bilen?");
            int dagar = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Hur många kilometer ska du köra?");
            int km = int.Parse(Console.ReadLine());


           

            Console.WriteLine( avgift + dagar * 500 - 500 + km );

        }
    }
 }
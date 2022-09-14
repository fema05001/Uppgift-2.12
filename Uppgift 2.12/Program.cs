using System;

namespace Uppgift_2_11
{
    class program
    {
        static void Main(string[] Args)
        {
            int x = 300;
            Console.WriteLine("Hur många kilometer vill du köra?");
            string y =Console.ReadLine();
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            string z =Console.ReadLine();
            int a = int.Parse(y);
            int b = int.Parse(z);
            Console.Write("Den totala hyran blir ");
            Console.Write( x + a + (b * 500));
        }
    }
}
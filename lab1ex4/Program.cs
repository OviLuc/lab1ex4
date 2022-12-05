using System;

namespace lab1ex4
{
    class Program
    {
        static void Main(string[] args)
        { /* Scrieti un program care va recunoaste daca un numar este pozitiv negativ sau zero */

            Console.WriteLine("Acest program va afisa semnul negativ sau pozitiv al unui numar");

            Console.WriteLine("Introduceti numarul");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("+");
            }
            else if(x < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

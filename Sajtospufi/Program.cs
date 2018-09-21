using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sajtospufi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg 10 számot!");
            int i = 0;
            int legnagyobb = 0;
            int[] szamok = new int[10];
            do
            {
                Console.Write("\nA(z) {0}. szám: ", i + 1);
                szamok[i] = Convert.ToInt32(Console.ReadLine());
                if (szamok[i] > legnagyobb)
                {
                    legnagyobb = szamok[i];
                }
                i++;
            } while (i != szamok.Length);
            Console.WriteLine("A legnagyobb megadott szám: {0}",legnagyobb);

            Console.ReadKey();
        }
    }
}

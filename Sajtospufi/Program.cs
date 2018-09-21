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
            Console.WriteLine("Kérem adja meg hány elemet akar megadni!");
            int hanyat = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int legnagyobb = 0;
            int legkisebb;
            int[] szamok = new int[hanyat];
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
            legkisebb = szamok[0];
            for (int j = 0; j < szamok.Length; j++)
            {
                if (szamok[j] < legkisebb)
                {
                    legkisebb = szamok[j];
                }
            }
            Console.WriteLine("A legkisebb megadott szám: {0}",legkisebb);

            Console.ReadKey();
        }
    }
}

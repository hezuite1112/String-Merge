using System;

namespace StringMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] tekst = Console.ReadLine().Split(' ');
                Console.WriteLine(Polocz(tekst[0], tekst[1]));
            }
        }

        private static string Polocz(string a, string b)
        {
            int dlugosc = a.Length < b.Length ? a.Length : b.Length;
            string wynik = "";
            for (int i = 0; i < dlugosc; i++)
            {
                wynik += a[i];
                wynik += b[i];
            }
            return wynik;
        }
    }
}

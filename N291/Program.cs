namespace N291
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] a = { 1, 5, 7, 2, 6, 7, 3, 5, 7, 8, 2, 5, 4, 1 };

            int antal = a.Count();
            Console.WriteLine($"Antal: {antal}");

            int antalSyvere = a.Count(x => x == 7);
            Console.WriteLine($"Antal 7'ere: {antalSyvere}");

            int sum = a.Sum();
            Console.WriteLine($"Sum: {sum}");

            double gennemsnit = a.Average();
            Console.WriteLine($"Gennemsnit: {gennemsnit}");

            var sorteretArray = a.OrderBy(x => x).ToArray();
            Console.WriteLine($"Sorteret array: {string.Join(", ", sorteretArray)}");

            var talOverFem = a.Where(x => x > 5).ToArray();
            Console.WriteLine($"Tal over 5: {string.Join(", ", talOverFem)}");

            var deFørsteFem = a.Take(5).ToArray();
            Console.WriteLine($"De første 5 tal: {string.Join(", ", deFørsteFem)}");

            var tal6til10 = a.Skip(5).Take(5).ToArray();
            Console.WriteLine($"Tal nr. 6-10: {string.Join(", ", tal6til10)}");

            Console.ReadLine();
        }
    }
}

namespace N140
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Læg 1 + 2 sammen:");
            Console.WriteLine(LægSammen(1,2));

            Console.WriteLine("\nBeregn areal af cirkle med radius = 2");
            Console.WriteLine(BeregnAreal(2));
            
            Console.WriteLine("\nBeregn beløb efter moms af 100 kr.");
            Console.WriteLine(BeregnBeløbEfterMoms(100, .25) + " Kr.");
            
            Console.WriteLine("\nTest Udskriv metode:");
            Console.WriteLine(Udskriv("Testing 1,2,3..."));
        }
        static int LægSammen(int a, int b)  
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * Math.PI;
        }

        static double BeregnBeløbEfterMoms(double beløb, double momsPct)
        {
            return beløb * (1 + momsPct);
        }

        static string Udskriv(String txt)
        {
            return txt;
        }
    }
}

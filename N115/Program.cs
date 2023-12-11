namespace N115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();

            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            //konverter til double og læg sammen
            double t2 = System.Convert.ToDouble(tal2);
            double t1 = System.Convert.ToDouble(tal1);
            double resultat = t1 + t2;

            //Udskriv og konverter til string
            Console.WriteLine("Resultat: ");
            Console.WriteLine(resultat.ToString("N2"));
        }   
    }
}

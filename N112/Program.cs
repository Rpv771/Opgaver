namespace N112
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KortVærdi kort1Værdi = KortVærdi.To;
            KortKulør kort1Kulør = KortKulør.Hjerter;
            Console.WriteLine(kort1Kulør.ToString() + " " + kort1Værdi);

            KortVærdi kort2Værdi = KortVærdi.Tre;
            KortKulør kort2Kulør = KortKulør.Ruder;
            Console.WriteLine(kort2Kulør.ToString() + " " + kort2Værdi);
            
            Console.WriteLine(Convert.ToInt32(kort2Kulør));
        }
    }
    enum KortKulør
    {
        Hjerter,
        Ruder,
        Klør,
        Spar
    }
    enum KortVærdi
    {
        En,
        To,
        Tre,
        Fire,
        Fem,
        Seks,
        Syv,
        Otte,
        Ni,
        Ti,
        Knægt,
        Dame,
        Konge,
        Es
    }

}

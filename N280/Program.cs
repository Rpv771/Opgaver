namespace N280
{
    class Program
    {
        static void Main()
        {
            // Opret et array af IDbFunktioner
            IDbFunktioner[] array = new IDbFunktioner[4];

            // Tilføj objekter af både Hund og Ubåd
            array[0] = new Hund { Navn = "Rasmus" };
            array[1] = new Ubåd { Nummer = 1, Turbine = 1.0 };
            array[2] = new Hund { Navn = "Anders" };
            array[3] = new Ubåd { Nummer = 2, Turbine = 2.0 };

            // Løb igennem arrayet og kald Gem() for hvert objekt
            foreach (var objekt in array)
            {
                objekt.Gem();
            }

            // Hold cmd åben
            Console.ReadLine();
        }
    }
    interface IDbFunktioner
    {
        void Gem();
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }
       
}

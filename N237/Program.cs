namespace N237
{
    class Program
    {
        static void Main(string[] args)
        {
            TreKant t = new TreKant(10, 100);
            Console.WriteLine($"Areal {t.Areal}");
        }
    }

    public class TreKant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public TreKant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        public double Areal
        {
            get
            {
                return this.Grundlinje * this.Højde * 0.5;
            }
        }
    }
}

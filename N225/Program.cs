using System;

namespace MinTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
        }
    }

    public class Terning
    {
        private int værdi;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                    value = 1;
                Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            System.Random rnd = new Random();
            this.Værdi = rnd.Next(1,7);
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

    }



}

namespace N282
{
    class Program
    {
        static void Main()
        {
            using (MinKlasse mk = new MinKlasse())
            {
                mk.Test();
            }
            Console.ReadLine();
        }
    }
    class MinKlasse : IDisposable
    {
        public void Test()
        {
            Console.WriteLine("Testing 123...");
        }

        public MinKlasse()
        {
            Console.WriteLine("Bliver født");
        }

        public void Dispose()
        {
            Console.WriteLine("Rydder op");
        }
    }
}

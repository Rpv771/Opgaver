namespace N125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Udskriv tallene fra 1-9
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Udskriv tallene 1-9:\n");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            //Udskriv hvert andet tal fra 1-20
            Console.WriteLine("\nUdskriv hver anden tal fra 1-20:\n");
            for (int i = 1; i < 21; i+=2)
            {
                Console.WriteLine(i);
            }

            //Udskriv tallene 1-20, hvor lige er gule, og ullige er røde:
            Console.WriteLine("\nUdskriv hver tallene fra 1-20, hvor lige er gule, og ullige er røde:\n");
            for (int i = 1; i < 21; i++)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
            
    }
}

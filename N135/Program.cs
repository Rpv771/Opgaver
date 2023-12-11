namespace N135
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 19; i++)
            {
                if (i % 3 != 0)
                    continue;

                if (i > 15)
                    break;

                Console.WriteLine(i);
            }
        }
    }
}

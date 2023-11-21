namespace N150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //På typen
            bool findesFil = System.IO.File.Exists(@"c:\temp\test.txt");    
            Console.Write("Findes fil:\n");
            if (findesFil)
            {
                Console.WriteLine("Ja");
                Console.WriteLine($"\nIndhold af fil:");
                string indhold = System.IO.File.ReadAllText(@"c:\temp\test.txt");
                Console.WriteLine(indhold);

                // På instance
                var fil = new System.IO.FileInfo(@"c:\temp\test.txt");
                DateTime d = fil.LastAccessTime;
                Console.WriteLine($"Fil sidst åbnet: \n{d}");
                string ex = fil.Extension;
                Console.WriteLine($"\nFilens extension: \n{ex}");
            }
            else 
                Console.WriteLine("Nej");
        }
    }
}

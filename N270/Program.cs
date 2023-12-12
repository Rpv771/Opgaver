namespace N270
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            try
            {
                string mappeSti = @"c:\temp";
                string filSti = Path.Combine(mappeSti, "data.txt");

                // Check om mappe eksisterer
                bool mappeEksisterer = Directory.Exists(mappeSti);
                Console.WriteLine($"Mappen eksisterer: {mappeEksisterer}");

                if (!mappeEksisterer)
                {
                    Directory.CreateDirectory(mappeSti);
                    File.WriteAllText(filSti, "Dette er en testfil.");
                }

                // Udskriv navnet på samtlige filer i mappen
                string[] filer = Directory.GetFiles(mappeSti);
                Console.WriteLine($"Filer i mappen: {string.Join(", ", filer)}");

                // Check om filen eksisterer
                bool filEksisterer = File.Exists(filSti);
                Console.WriteLine($"Filen eksisterer: {filEksisterer}");

                // Overskriv indholdet i filen med "xxx"
                File.WriteAllText(filSti, "xxx");

                // Tilføj "yyy" til filen
                File.AppendAllText(filSti, "yyy");

                // Udskriv indhold
                string filIndhold = File.ReadAllText(filSti);
                Console.WriteLine($"Filens indhold: {filIndhold}");

                // Slet filen
                File.Delete(filSti);

            }
            catch (IOException ex)
            {
                Console.WriteLine($"Fejl opstod: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}

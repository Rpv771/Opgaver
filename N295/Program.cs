namespace N295
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main()
        {
            try
            {
                HttpClient randomTal = new HttpClient();
                await randomTal.GetStringAsync("https://www.random.org/integers/?num=1&min=10&max=100&col=1&base=10&format=plain&rnd=new");
                await File.AppendAllTextAsync(@"C:\temp\random_tal.txt", randomTal.ToString());
                Console.WriteLine("Random tal hentet og gemt i fil");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl: {ex.Message}");
            }
        }
    }
}

namespace N120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
            new System.Globalization.CultureInfo("da-DK");

            string fornavn = "Rasmus";
            string efternavn = "Vinther";

            string samletNavn = $"{fornavn} {efternavn}";
            Console.WriteLine(samletNavn);
            
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            
            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            Console.WriteLine($"{fornavn} \n\t {efternavn}");
            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
            string samletNavn2 = $"{fornavn} {efternavn}";
        }
    }
}

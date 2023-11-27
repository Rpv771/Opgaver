using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace MinApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Efternavn = "Vinther";
            p1.Fornavn = "Anders";
            p1.Fødselsår = 1985;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());

            Person p2 = new Person("Rasmus", "Vinther", 1988);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());

            // Til string
            // Medtag felter og sørg for at ØÆÅ håndteres korrekt i JSON
            var options = new JsonSerializerOptions { IncludeFields = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Latin1Supplement) };

            // Serialisering
            string json = System.Text.Json.JsonSerializer.Serialize(p2, options);
            Console.WriteLine(json);

            // Fra string
            Person p3 = System.Text.Json.JsonSerializer.Deserialize<Person>(json, options);
        }
    }

    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        // Default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        // Custom constructor
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }
    }
}
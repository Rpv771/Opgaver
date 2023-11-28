using System.Collections.Generic;
namespace N239
{
   internal class Program
   {
        static void Main(string[] args)
        {
        string json = System.IO.File.ReadAllText(@"c:\temp\test2.txt");
        List<Person> list = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(json);

        foreach (var item in list)
        {
            Console.WriteLine("Id: " + item.Id);
            Console.WriteLine("Navn: " + item.Navn);
            Console.WriteLine("Er Dansk: " + item.ErDansk);
            Console.WriteLine("Dato: " + item.Dato+"\n");
        }



        }
   }

   public class Person
   {
   public int Id { get; set; }
   public string Navn { get; set; }
   public bool ErDansk { get; set; }
   public DateTime Dato { get; set; }
   }
   
}

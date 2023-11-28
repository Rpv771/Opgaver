namespace N275
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person rasmus = new Person(100, "Rasmus",200, true);
            PersonEkstra anders = new PersonEkstra(30, "anders", 400, false);
            Console.WriteLine(rasmus.Navn);
            Console.WriteLine(anders.NavnMedStort);
                        
        }
    }
    public record Person(
        int Id, 
        string Navn, 
        int Alder, 
        bool ErDansk);
    public record PersonEkstra(int Id, string Navn, int Alder, bool ErDansk)
    {
        public string NavnMedStort => Navn.ToUpper();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        Person k1 = new Person();
        k1.Id = 1;
        Person k2 = new Person();
        k2.Id = 2;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);
        k1 = k2;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);
        k1.Id = 3;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);
    }
}

class Person    // ret til class Person jf. opgave
{
    public int Id;
}

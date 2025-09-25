Hello();
Hello();
Hello();
Hello();
Kraj();
Pozdrav("Igor");
Pozdrav("Igor", "Jakopiček");

partial class Program
{
    static void Hello()
    {
        Console.WriteLine("Živjeli potprogrami!");
    }

    static void Kraj()
    {
        Console.WriteLine("Pritisnite bilo koju tipku za kraj...");
        Console.ReadKey();
        Console.WriteLine();
    }

    static void Pozdrav(string ime)
    {
    Console.WriteLine("Dobro veče, {0}!", ime);
    }

    //overload metode pozdrav (zapravo je ova iznad overload)
    static void Pozdrav()
    {
        Console.WriteLine("Pozdrav svijetu");
    }

    //drugi overload metode pozdrav - prima 2 string paramentra
    static void Pozdrav(string ime, string prezime)
    {
        Console.WriteLine("Dobro veče, {0} {1}!", ime, prezime);
    }
}
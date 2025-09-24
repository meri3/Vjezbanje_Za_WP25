/* Napiši program u kojem se traži unos cijelog broja (može biti i negativan) pa se ispisuje je li
broj jednoznamenkast, dvoznamenkast, troznamenkast ili višeznamenkast */

Console.WriteLine("Unesi cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj < 0) broj = -broj;

if (broj < 10)
{
    Console.WriteLine("Broj je jednoznamenkast!");
}
if (broj < 100)
{
    Console.WriteLine("Broj je dvoznamenkast");
}//...
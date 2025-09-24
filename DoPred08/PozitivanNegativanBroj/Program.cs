/* Napiši program u kojem se traži unos broja pa se ispisuje je li broj negativan, pozitivan ili niti
negativan niti pozitivan (nula). */

Console.WriteLine("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj > 0)
{
    Console.WriteLine("Broj je pozitivan");
}
if (broj == 0)
{
    Console.WriteLine("Broj je nula");
}
if (broj < 0)
{
    Console.WriteLine("Broj je negativan");
}
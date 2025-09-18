/* Unesi cijeli broj.
Broj je specijalan ako je:
- pozitivan i djeljiv s 3,
- ali nije djeljiv s 9,
- osim ako je također paran → onda opet je specijalan.

Inače → “Broj nije specijalan.”
*/


Console.Write("Unesi cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj % 2 == 0) // iznimka: svaki paran broj je specijalan
{
    Console.WriteLine("Broj je specijalan");
}
else if (broj > 0 && broj % 3 == 0 && broj % 9 != 0) // osnovno pravilo
{
    Console.WriteLine("Broj je specijalan");
}
else
{
    Console.WriteLine("Broj nije specijalan");
}


//Zadatak 2:Napravi program koji traži unos brojeva od korisnika dok zbroj svih
//unesenih brojeva ne premaši 100. Kada se to dogodi, program treba ispisati konačni
//zbroj. 


using System.Linq.Expressions;

int zbroj = 0;

while (zbroj < 100)
{
    try
    {
        Console.Write("Unesi broj: ");
        int broj = int.Parse(Console.ReadLine());
        zbroj += broj;
    }
    catch (Exception ex)
    {
        Console.Write("Ups...");
    }
}


Console.WriteLine("zbroj je: " + zbroj);
//Zadatak 3: Napravite program koji traži unos riječi od korisnika. Program treba
//nastaviti tražiti unos dok korisnik ne unese riječ koja je već prethodno unesena.
//Nakon toga, program treba ispisati riječ koja se ponovila i završiti izvršavanje

using System.Globalization;

List<string> uneseneRijeci = new List<string>();

while (true)
{
	try
	{
        Console.Write("Unesi riječ: ");
        string rijec = Console.ReadLine();

        if (uneseneRijeci.Contains(rijec))
		{
			Console.WriteLine("Ponovljena rijec je: ");
			break;
		}
		else
		{
			uneseneRijeci.Add(rijec);
		}
	}
	catch (Exception)
	{

		throw;
	}
}
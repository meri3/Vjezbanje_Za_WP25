// Napiši program u kojem se traži unos broja i ispisuje je li broj u intervalu [0, 12] ili nije

while (true)
{ 
Console.Write("Unesi broj: ");
string unos = Console.ReadLine();

	try
	{
        int broj = int.Parse(unos); //moramo staviti tu ovaj dio koda a ne iznad.
									//To fix this, move the line int broj = int.Parse(unos); inside the try block.
									//This way, if the user enters an invalid value, the exception will be caught,
									//and the user will be prompted to try again.

        if (broj >= 0 && broj <= 12)
		{
			Console.WriteLine("Broj {0} je u intervalu [0, 12]", broj);
		}
		else
		{
			Console.WriteLine("Broj {0} nije u intervalu [0, 12]", broj);

		}

		break; //prekida petlju ako je unos uspješan
	}
	catch (Exception e)
	{

		Console.WriteLine("Ups... Dogodila se greška: " + e.Message);
		Console.WriteLine("Pokušaj ponovno\n");
	} 
}
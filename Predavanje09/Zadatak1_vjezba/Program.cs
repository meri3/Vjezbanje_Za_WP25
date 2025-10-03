/* korisnik unese broj od 1 do 100 i program napiše koliko ima parnih i neparnih manjih od tog broja 
 i većih od to broja */

Console.Write("Unesi broj u rasponu [1,100]: ");
int broj = int.Parse(Console.ReadLine());
int parniManji = 0;
int parniVeci = 0;
int neparniManji = 0;
int neparniVeci = 0;


		for (int i = 0; i < broj; i++)
		{
			if (i % 2 == 0)
			{
				parniManji++;
			}
			else 
			{
				neparniManji++;
			}
		}

		for (int i = broj; i <= 100; i++)
		{
			if (i % 2 == 0)
			{
				parniVeci++;
			}
			else 
			{
				neparniVeci++;
			}
		}
        Console.WriteLine($"Parnih manjih od {broj}: {parniManji}, neparnih: {neparniManji}");
        Console.WriteLine($"Parnih većih od {broj}: {parniVeci}, neparnih: {neparniVeci}");
	 
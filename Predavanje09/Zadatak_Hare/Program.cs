/* Napiši tekst a on zbroji samoglasnike*/

Console.WriteLine("Unesi rečenicu: ");
string recenica = Console.ReadLine();
List<char> samoglasnici = new List<char>(); 

foreach (char slovo in recenica)
{
	if (slovo == 'a' || slovo == 'e' || slovo == 'i' || slovo == 'o' || slovo == 'u')
	{
		samoglasnici.Add(slovo);
	}
}
Console.Write("U rečenici {1} ima {0} samoglasnika: ", samoglasnici.Count(), recenica);
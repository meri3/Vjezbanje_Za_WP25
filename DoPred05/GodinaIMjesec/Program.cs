/* 4.Godina i mjesec

Unesi godinu i mjesec.

Ako je godina prijestupna i mjesec je veljača → “Veljača ima 29 dana.”

Ako godina nije prijestupna i mjesec je veljača → “Veljača ima 28 dana.”

Ako je mjesec 4, 6, 9 ili 11 → “Mjesec ima 30 dana.”

Inače → “Mjesec ima 31 dan.”

(ovdje moraš kombinirati uvjete i dobro paziti na “osim ako” kod veljače) */

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Unesi godinu: ");
int godina = int.Parse(Console.ReadLine());

Console.Write("Unesi naziv mjeseca: ");
string mjesec = Console.ReadLine();

if ((godina % 400 == 0 || (godina % 4 == 0 && godina % 100 != 0)) && mjesec == "veljača")
{
    Console.WriteLine("Veljača ima 29 dana");
}
else if ((godina % 400 != 0 || (godina % 4 != 0 && godina % 100 == 0)) && mjesec == "veljača")
{
    Console.WriteLine("Veljača ima 28 dana");
}
else if (mjesec == "travanj" || mjesec == "lipanj" || mjesec == "rujan" || mjesec == "studeni")
{
    Console.WriteLine("Mjesec ima 30 dana");
}
else
{
    Console.WriteLine("Mjesec ima 31 dan");
}


//Napiši program koji ispisuje sumu prvih 100 prirodnih brojeva
// 1 + 2 + 3 + 4 + ... + 95 + 96 + 97 + 98 + 99 + 100

int suma = 0;

for (int i = 1; i <= 100; i++)
{
    Console.Write(suma + " "); // da ovo napravimo ispisalo bi 0 sto puta
}

for (int i = 1; i <= 100; i++)
{
    suma += i;
}
Console.WriteLine("\nSuma prvih sto prirodnih brojeva je: " + suma);
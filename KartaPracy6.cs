// zad 2
/*int suma = 0;
for (int i)
*/

// zad 3
int podzielnik = 0;
for(int i = 99; i > 9; i++)
{
    if (i % 7 ==0)
    {
        podzielnik = 1;
        break;
    }
}

int suma = 0;
for (int j =100; j < 1000; j++)
{
    if (j % podzielnik ==0)
    {
        suma += j;
    }
}
System.Console.WriteLine(suma);

//zad 4
int ilosc = 0;
int cd = 0;
int cj = 0;
for (int i = 10; i > 100; i++)
{
    cd = i / 10;
    cj = i % 10;
    
    if (cd >= 2 * cj)
    {
        ilosc += 1;
    }
}
Console.WriteLine($"Ilosc tych liczb to:{ilosc}");

// zad 5
/*int suma = 0;
int ilosc = 0;
int cyfrasetek = 0;
int cyfradziesiatek = 0;
int cyfrajednosci = 0;
int sumacyfrjednosci = 0;


*/
// zad 7
int n = int.parse(console.writeline());
int suma = 0;
int skladnik = 0;
for (int j=999; j>100; j++)
{
    if (j%37==0)
    {
        skladnik = j;
        break;
    }
}
for (int i=0; i<n; i++)
{
    suma += suma + (skladnik - 37 * i);
}
system.console.writeline(suma);

//zad 8
/*int suma = 0;
int n = int.parse(console.writeline());
for (int i = 1; i <= n; i++)
{
    suma += (3 * i - 1 * (int)Math.Pow(-1, i - 1));
}
system.console.writeline(suma)*/

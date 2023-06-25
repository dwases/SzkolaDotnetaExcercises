﻿//zadanie1
int ilość_pierwszych = 0;
bool niepierwsza = false;

for  (int i = 0; i <= 100; i++)
{
    if (i == 0)
    {
        continue;
    } 
    else if (i == 1)
    {
        continue;
    }      
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            niepierwsza = true;
            break;
        }
    }
    if (!niepierwsza)
    {
        ilość_pierwszych++;
        niepierwsza = !niepierwsza;
    }
    niepierwsza = false;
}
Console.WriteLine("Ilość liczb pierwszych w przedziale od 0 do 100, to: "+ilość_pierwszych);

//zadanie2
int n = 0;
Console.WriteLine("Wynik zadania drugiego: ");
do
{
    if (n % 2 == 0)
    {
        Console.Write(" "+ n);
    }
    n++;
}
while (n<=1000);

//zadanie3
var n1 = 0;
var n2 = 1;
var temp = 0;

Console.WriteLine("\nCiąg Fibonacciego: ");
Console.Write(" " + n1);
Console.Write(" " + n2);
for  (int i = 0; i <= 10; i++)
{
    temp = n1 + n2;
    Console.Write(" " + temp);
    n1 = n2;
    n2 = temp;
}

//zadanie4
Console.WriteLine("\nPodaj liczbę do zbudowania piramidy: ");
int num = Convert.ToInt32(Console.ReadLine());
int e_now = 0;
int e_max = 1;
for(int i = 1; i <= num; i++)
{
    e_now++;
    Console.Write(i+" ");
    if(e_now == e_max)
    {
        Console.Write("\n");
        e_max++;
        e_now = 0;
    }
}

//zadanie5
Console.Write("\n");
Console.WriteLine("Wynik zadania piątego: ");
for (int i = 1; i<=20; i++)
{
    Console.Write(" " + i*i*i);
}

//zadanie6
double suma = 0.0;
for(int i = 1; i<=20;i++)
{
    suma += Convert.ToDouble(1) / Convert.ToDouble(i);
}
Console.WriteLine("\nSuma odwrotności: " + suma);

//zadanie7
Console.WriteLine("Podaj długość krótszej przekątnej diamentu: ");
int short_diag = Convert.ToInt32(Console.ReadLine());
if (short_diag % 2 == 0)
    System.Console.WriteLine("Diament wymaga nieparzystego wymiaru przekątnej.");
else
{
    int spaces = short_diag / 2;
    for(int i  = 0; i <= short_diag; i+=2)
    {
        Console.Write("\n");
        for(int j = 0; j <= spaces; j++)
        {
            Console.Write(' ');
        }
        spaces--;
        for(int j=0; j <= i; j++)
        {
            Console.Write("*");
        }
    }

    spaces = 1;
    for (int i = short_diag-2; i >= 0; i -= 2)
    {
        Console.Write("\n");
        for (int j = 0; j <= spaces; j++)
        {
            Console.Write(' ');
        }
        spaces++;
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
    }
}

//zadanie8
Console.WriteLine("Podaj stringa do odwrócenia: ");
string seq = Console.ReadLine();
Console.WriteLine();
for (int i = seq.Length-1; i >=0; i--)
{
    Console.Write(seq[i]);
}


//zadanie9
Console.WriteLine("Podaj liczbę dziesiętną do konwersji: ");
int dec = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
List<int> bin = new List<int>();

while (dec > 0)
{
    bin.Add(dec%2);
    dec /= 2;
}
for (int i = bin.Count-1; i >= 0; i--)
    Console.Write(bin[i]);

//zadanie10
Console.WriteLine("Podaj dwie liczby: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int x;
int a2 = a;
int b2 = b;
while(b!=0)
{
    x = b;
    b = a % b;
    a = x;
}
Console.WriteLine("wynik nww: "+Convert.ToDouble(a2/a*b2));
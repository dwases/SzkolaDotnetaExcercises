//zadanie1
string surname;
int name;
int age;
char sex;  //'m' lub 'k'
string pesel;
int workerID;

//zadanie2
char a = 'a';
char b = 'b';
char c = 'c';
Console.WriteLine(c+b+a);

//zadanie3
Console.WriteLine("Podaj wysokość prostokąta");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj długość prostokąta");
double x = Convert.ToDouble(Console.ReadLine());
double d = Math.Pow((Math.Pow(x, 2) + Math.Pow(y, 2)), 0.5);
Console.WriteLine("Długość przekątnej wynosi: " + d);

//zadanie4
int z1;
double z2;
string z3;
z1 = 10;
z2 = 12.5;
z3 = "Szkoła dotneta";

//zadanie5
Console.WriteLine("Podaj swoje imię:");
string name5 = Console.ReadLine();
Console.WriteLine("Podaj swoje nazwisko");
string surname5 = Console.ReadLine();
Console.WriteLine("Podaj swój numer telefonu:");
int tel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj swój adres email:");
string email = Console.ReadLine();
Console.WriteLine("Podaj swój wzrost: ");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj swoją wagę: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj swoją płeć(m lub k): ");
char sex5 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Podaj swoją ojczyznę: ");
string homeland  = Console.ReadLine();
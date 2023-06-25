using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

//zadanie1
int a  = 5;
int b = 5;

Console.WriteLine(a == b ? a + " i " + b + " są równe" : a + " i " + b + " są różne");

//zadanie2
Console.WriteLine("Podaj liczbę żeby sprawdzić czy jest parzysta: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number1 % 2 == 0 ? number1 + " jest liczbą parzystą" : number1 + " jest liczbą nieparzystą");

//zadanie3
Console.WriteLine("Podaj liczbę żeby sprawdzić czy jest dodatnia czy ujemna: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number2 >= 0 ? number2 + " jest liczbą dodatnią" : number2 + " jest liczbą ujemną");

//zadanie4
Console.WriteLine("Podaj rok żeby sprawdzić czy jest przestępny: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(year % 4 == 0 ? year + " jest rokiem przestępnym" : year + " nie jest rokiem przestępnym");

//zadanie5
Console.WriteLine("Podaj swój wiek żeby sprawdzić czy możesz zostać posłem, senatorem, premierem, lub prezydentem: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Możesz zostać");
if (age >= 21)
{
    Console.Write(" posłem");
}
else
{
    Console.Write(" absolutnie nikim");
}
if (age >= 35)
{
    Console.Write(", prezydentem");
}
if (age >= 30)
{
    Console.Write(", senatorem");
}
if (age >= 35)
{
    Console.Write(", premierem");
}

//zadanie6
Console.WriteLine("\nPodaj swój wzrost: ");
int height = Convert.ToInt32(Console.ReadLine());
if (height >= 200)
    Console.WriteLine("Jesteś elfem :O");
else if (height < 200 && height > 140)
    Console.WriteLine("Jesteś człowiekiem");
else if (height <= 140 && height > 0)
    Console.WriteLine("Jesteś krasnoludem");
else
    Console.WriteLine("Jesteś kłamczuchem");

//zadanie7
Console.WriteLine("Wprowadź trzy liczby w nowych liniach:");
int[] nums = new int[3];
nums[0] = Convert.ToInt32(Console.ReadLine());
nums[1] = Convert.ToInt32(Console.ReadLine());
nums[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(nums.Max()+" jest największa z podanych:");

//zadanie8
List<int> matury = new List<int>();
Console.WriteLine("Podaj wyniki matury z matematyki");
matury.Add(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Podaj wyniki matury z fizyki");
matury.Add(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Podaj wyniki matury z chemii");
matury.Add(Convert.ToInt32(Console.ReadLine()));

bool isAllowed = false;
if (matury[0] > 70 && matury[1] > 55  && matury[2] > 45 && matury.Sum() > 180)
    isAllowed = true;
else if (matury[0] + matury[1] > 150 || matury[0] + matury[2] > 150)
    isAllowed = true;

if (isAllowed)
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
else
    Console.WriteLine("Kandydat nie został dopuszczony do rekrutacji");

//zadanie9
Console.WriteLine("Podaj temperaturę: ");
int temp = Convert.ToInt32(Console.ReadLine());

if (temp < 0)
    Console.WriteLine("Cholernie piździ");
else if (temp >= 0 && temp < 10)
    Console.WriteLine("zimno");
else if (temp >= 10 && temp < 20)
    Console.WriteLine("chlodno");
else if (temp >= 20 && temp < 30)
    Console.WriteLine("w sam raz");
else if (temp >= 30 && temp < 40)
    Console.WriteLine("zaczyna być słabo, bo gorąco");
else if (temp >= 40)
    Console.WriteLine("a weź wyprowadzam się na Alaskę.");

//zadanie10
Console.WriteLine("Podaj trzy długości boków: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x < y + z && y < x + z && z < y + x ? "Można zbudować trójkąt" : "Nie można zbudować trójkąta");

//zadanie11
Console.WriteLine("Podaj ocenę liczbową: ");
int grade = Convert.ToInt32(Console.ReadLine());
switch (grade)
{
    case 6:
        Console.WriteLine("Celujący");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry");
        break;
    case 4:
        Console.WriteLine("Dobry");
        break;
    case 3:
        Console.WriteLine("Dostateczny");
        break;
    case 2:
        Console.WriteLine("Dopuszczający");
        break;
    case 1:
        Console.WriteLine("Niedostateczny");
        break;
    default:
        //pass
        break;
}

//zadanie12
Console.WriteLine("Podaj numer dnia tygodnia: ");
int daynum = Convert.ToInt32(Console.ReadLine());
switch (daynum)
{
    case 7:
        Console.WriteLine("Niedziela");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 5:
        Console.WriteLine("Piątek");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 3:
        Console.WriteLine("Środa");
        break;
    case 2:
        Console.WriteLine("Wtorek");
        break;
    case 1:
        Console.WriteLine("Poniedziałek");
        break;
    default:
        //pass
        break;
}


//zadanie13
Console.WriteLine("Podaj pierwszą liczbę: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj numer operacji do wykonania: ");
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");
int choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Twój wynik to: ");
switch (choice)
{
    case 4:
        Console.WriteLine(m/n);
        break;
    case 3:
        Console.WriteLine(m*n);
        break;
    case 2:
        Console.WriteLine(m-n);
        break;
    case 1:
        Console.WriteLine(m+n);
        break;
    default:
        //pass
        break;
}
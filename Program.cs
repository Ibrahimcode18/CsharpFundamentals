// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int number1 = 2100000000;
int number2 = 2100000000;

long total = (long)number1 + (long)number2;
Console.WriteLine(total);

float number3 = 4.51F; // F is needed for explicit declaration
double number4 = 3.23; // The original datatype of decimal numbers is double,that is why d is not needed here

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

int yt = 7;
int ba = 5;

if (yt + ba > 10)
{
    Console.WriteLine("Yes it is");
} else if (yt + ba == 10)
{
    Console.WriteLine("It is equal to 10");
} else
{
    Console.WriteLine("Try again mate");
}


// loops
int x = 3;
while (3 > x)
{
    Console.WriteLine("3 is greater");
    x++;
}

for (int i = 0; i < 8; i++)
{
    Console.WriteLine(i);
}

// Lists
List<string> names = ["<name>", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

var namew = new List<string>{"John", "Jane", "Doe"};
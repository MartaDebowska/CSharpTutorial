// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

Console.WriteLine("Hello, World!");



int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);


// subtraction
c = a - b;
Console.WriteLine(c);

// multiplication
c = a * b;
Console.WriteLine(c);

// division
c = a / b;
Console.WriteLine(c);

var names = new List<string> { "Marta", "Ana", "Felipe" };
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


// WorkWithIntegers();
OrderPrecedence();

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

int aa = 7;
int bb = 4;
int cc = 3;
int dd = (aa + bb) / cc;
int ee = (aa + bb) % cc;
Console.WriteLine($"quotient: {dd}");
Console.WriteLine($"remainder: {ee}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// Challange to calculate the area of a circle

double radius = 2.50;
double area = radius * radius * Math.PI;
Console.WriteLine($"Area of the circle equals to {area}");
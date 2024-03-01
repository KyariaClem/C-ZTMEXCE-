// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// while loop
int pv = 1;

while(pv < 21) {
    Console.WriteLine($"point vale is {pv}");
    pv++;
}

// create if for less than 10
int hv = 9;

if(hv < 10) {
    Console.WriteLine($"Value is less than 10: {hv}");
} else {
    Console.WriteLine($"Point value is more than 10: {hv}");
}

// Happy Birthday inout with swutch statements
Console.WriteLine("How old are you turning?: ");
string input = Console.ReadLine();
int age = int.Parse(input);

switch(age)
{
    case < 10:
    Console.WriteLine("Happy birthday single dights");
    break;

    case < 30:
    Console.WriteLine("Happy Birthday gen z");
    break;

    case < 60:
    Console.WriteLine("Happy Grand Birthday ");
    break;

    case < 100:
    Console.WriteLine("Happy Birthday of Wisdom !");
    break;
}


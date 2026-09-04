Console.WriteLine("Enter amount of SEK:");
string sekInput = Console.ReadLine()!;
int sek = int.Parse(sekInput);

double dollars = sek / 6.0;
double pounds = sek / 10.0;

Console.WriteLine($"Dollars: {dollars}");
Console.WriteLine($"Pounds: {pounds}");
Console.WriteLine("Enter Fahrenheit:");
string fahrenheitInput = Console.ReadLine()!;
double Fahrenheit = double.Parse(fahrenheitInput);

double celsius = 5 * (Fahrenheit - 32) / 9;

Console.WriteLine($"celsius: {celsius}");
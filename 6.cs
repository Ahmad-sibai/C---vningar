Console.WriteLine("Enter value for a:");
string aInput = Console.ReadLine()!;
double a = double.Parse(aInput);

Console.WriteLine("Enter value for x:");
string xInput = Console.ReadLine()!;
double x = double.Parse(xInput);

double result = a * Math.Pow(x, 3) + 7;

Console.WriteLine($"Result: {result}");
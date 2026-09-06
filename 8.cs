Console.WriteLine("Enter Length:");
string lengthInput = Console.ReadLine()!;
double Length = double.Parse(lengthInput);

Console.WriteLine("Enter Width:");
string widthInput = Console.ReadLine()!;
double Width = double.Parse(widthInput);

double area = Length * Width;
double perimeter = 2 * (Length + Width);

Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
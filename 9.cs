Console.WriteLine("Enter radius:");
string radiusInput = Console.ReadLine()!;
double radius = double.Parse(radiusInput);

double area = 3.14 * (radius * radius);

double circumference = 2 * (3.14 * radius);

double diameter = 2 * radius;

Console.WriteLine($"Area: {area}");
Console.WriteLine($"circumference: {circumference}");
Console.WriteLine($"diameter: {diameter}");

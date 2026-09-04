// 1. Read input for all three numbers
Console.WriteLine("Enter the first number:");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the third number:");
int num3 = int.Parse(Console.ReadLine()!);

// 2. Calculate sum and average
int sum = num1 + num2 + num3;
double average = sum / 3.0;

// 3. Print the results
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");
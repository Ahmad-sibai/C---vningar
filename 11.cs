Console.WriteLine("Enter Number 1:");
string numberOneInput = Console.ReadLine()!;
double NumberOne = double.Parse(numberOneInput);

Console.WriteLine("Enter Number 2:");
string numberTwoInput = Console.ReadLine()!;
double NumberTwo = double.Parse(numberTwoInput);

if (NumberOne > NumberTwo)
{
    Console.WriteLine($"{NumberOne} is bigger than {NumberTwo}");
} else if ( NumberOne < NumberTwo)
{
        Console.WriteLine($"{NumberOne} is less than {NumberTwo}");

}
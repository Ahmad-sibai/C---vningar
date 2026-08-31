Console.WriteLine("Enter amount of hours:");
string hoursInput = Console.ReadLine()!;
int hours = int.Parse(hoursInput);
int minutes = hours * 60;
int seconds = minutes * 60;
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Seconds: {seconds}");
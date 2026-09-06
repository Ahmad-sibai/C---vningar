Console.WriteLine("Enter Discount Percentage:");
string discountPercentage = Console.ReadLine()!;
double discount = double.Parse(discountPercentage);

Console.WriteLine("Enter Liter Amount:");
string literAmount = Console.ReadLine()!;
double Liter = double.Parse(literAmount);

Console.WriteLine("Enter Price Per Liter:");
string pricePerLiter = Console.ReadLine()!;
double literPrice = double.Parse(pricePerLiter);

double fullPrice = Liter * literPrice;

double finalPrice = fullPrice * (1 - (discount / 100.0));

Console.WriteLine($"Sum: {finalPrice}");

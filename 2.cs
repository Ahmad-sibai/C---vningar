/* 
En försäljare har delvis prestationslön. Han får 8000 kr per månad i grundlön och 9% av försäljningssumman. Skriv en funktion som beräknar lönesumman under en period. Försäljningssumman ska läsas in.
*/
// 1. Prompt for total sales and read input
Console.WriteLine("Enter total sales amount:");
string totalSalesInput = Console.ReadLine()!;
double salesAmount = double.Parse(totalSalesInput);

// 2. Prompt for number of months and read input
Console.WriteLine("Enter number of months:");
string monthsInput = Console.ReadLine()!;
int months = int.Parse(monthsInput);

// 3. Calculate and print total earnings for the period
Console.WriteLine((8000 * months) + (salesAmount * 0.09));
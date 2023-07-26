Console.WriteLine("Задача №4");
Console.WriteLine("Введите целое число 1: ");
string userInput = Console.ReadLine () ?? "";
int number1 = int.Parse (userInput);
Console.WriteLine("Введите целое число 2: ");
userInput = Console.ReadLine () ?? "";
int number2 = int.Parse (userInput);
Console.WriteLine("Введите целое число 3: ");
userInput = Console.ReadLine () ?? "";
int number3 = int.Parse (userInput);
int max=number1;
if (number2>max)
{max=number2;}
if (number3>max)
   { max=number3;}
Console.WriteLine($"Максимальное число {max} ");

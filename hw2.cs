Console.WriteLine("Задача №2 Определить большее число");
Console.WriteLine("Введите целое число 1: ");
string userInput = Console.ReadLine () ?? "";
int number1 = int.Parse (userInput);
Console.WriteLine("Введите целое число 2: ");
userInput = Console.ReadLine () ?? "";
int number2 = int.Parse (userInput);
if (number1==number2)
{Console.WriteLine($"Число {number1} равно числу Числу {number2} ");}
else
if (number1>number2)
{Console.WriteLine($"Число {number1} больше числа Числfа{number2} ");}
  else
{Console.WriteLine($"Число {number2} больше числа Числа {number1} ");}

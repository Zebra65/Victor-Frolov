Console.WriteLine("Задача №8");
Console.WriteLine("Введите целое число 1: ");
string userInput = Console.ReadLine () ?? "";
int number1 = int.Parse (userInput);
Console.WriteLine("Введите целое число 2: ");
userInput = Console.ReadLine () ?? "";
int number2 = int.Parse (userInput);
for (int i = number1; i <= number2; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    //}

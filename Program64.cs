/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message)
{
  int result = 0;
  while (true)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("You've entered incorrect number, please try again");
    }
  }
  return result;
}

void NumbersDown(int n)
{
  if (n > 0)
  {
    Console.Write($"{n}, ");
    NumbersDown(n - 1);
  }
}

int n = GetNumber("Enter N");
Console.Write($"N = {n} -> ");
NumbersDown(n);
Console.WriteLine();
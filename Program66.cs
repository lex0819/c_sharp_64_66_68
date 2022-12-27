/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int Summ(int m, int n)
{
  if (n == m)
  {
    return n;
  }
  else
  {
    return n + Summ(m, n - 1);
  }
}

int m = GetNumber("Enter low border as M");
int n = GetNumber("Enter hight border as N");
int summ = Summ(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {summ}");
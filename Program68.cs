/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

ulong GetNumber(string message)
{
  ulong result = 0;
  while (true)
  {
    Console.WriteLine(message);
    if (ulong.TryParse(Console.ReadLine(), out result) && result > 0)
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

ulong Ackermann(ulong m, ulong n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
    return Ackermann(m - 1, 1);
  else
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

ulong m = GetNumber("Enter first number as m");
ulong n = GetNumber("Enter second number as n");
ulong ackermann = Ackermann(m, n);
Console.WriteLine($"m = {m}; n = {n} -> A(m,n)={ackermann}");
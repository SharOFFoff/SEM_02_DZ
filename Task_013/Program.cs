// Task_013
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99)
{
  while (n > 999)
  {
    n = n / 10;
  }
Console.WriteLine(n % 10);
}

else
Console.WriteLine("третьей цифры нет");


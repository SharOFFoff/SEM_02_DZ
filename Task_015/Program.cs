// Task_015
Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
Console.Write("нет");

else
Console.Write("да");
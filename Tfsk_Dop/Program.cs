// Task_Dop
Console.Clear();
Console.Write("Введите последовательность чисел:\n");
int n = Convert.ToInt32(Console.ReadLine());

while(n < 1 || n > 100)
{
    Console.Write("Ошибка, введите число:\n");
    n = Convert.ToInt32(Console.ReadLine());   
}

int Max1 = n, Max2 = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine()); 
    if(n > Max1)
    {
        Max2 = Max1;
        Max1 = n;
    }
    else if(n > Max2) 
    Max2 = n; 
}
Console.WriteLine("end");
Console.WriteLine($"второй max = {Max2}");

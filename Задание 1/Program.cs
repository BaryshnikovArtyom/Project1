Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

int sum = a + b;
Console.WriteLine($"{a} + {b} = {sum}");

if (a > b)
{
    Console.WriteLine($"Наибольшее число: {a}");
}
else if (b > a)
{
    Console.WriteLine($"Наибольшее число: {b}");
}
else
{
    Console.WriteLine("Оба числа равны.");
}

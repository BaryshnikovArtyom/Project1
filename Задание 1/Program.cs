Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

// Вычисляем сумму
int sum = a + b;
Console.WriteLine($"{a} + {b} = {sum}");

// Вычисляем произведение
int product = a * b;
Console.WriteLine($"{a} * {b} = {product}");

// Находим наибольшее число
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

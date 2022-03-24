
System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
for  (int i = 1; i <= number; i++)
{
    System.Console.WriteLine($"Куб числа {i} = {Math.Pow(i, 3)} ");
}
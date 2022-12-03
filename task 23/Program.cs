Console.WriteLine("Введите число");
int aaa = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=aaa; i++)
{
    System.Console.Write($"{Math.Pow(i,3)}, ");
}

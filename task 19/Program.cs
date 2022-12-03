Console.WriteLine("Введите пятизначное число ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a/10000) == (a%10))
{ 
    a = (a/10) % 1000;
    if ((a/100)==(a%10))
    System.Console.WriteLine($"Число {a} - полиндром");
    else
    {
        System.Console.WriteLine($"Число {a} - не полиндром");
    }
}
else
{
    System.Console.WriteLine($"Число {a} - не полиндром");
}

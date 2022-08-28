Console.WriteLine("получаем на вход число пятизначное число и и проверяет, является ли оно палиндромом");

Console.WriteLine("Enter a five-digit number");
int N = int.Parse(Console.ReadLine());
if(N / 10000 == 0 || N /10000 > 9)
{
    Console.WriteLine("it is not a five-digit number");
}
else
{
    if(N / 1000 == N % 10 * 10 + N % 100 / 10)
    {
        Console.WriteLine("палиндром");
    }

    if(N / 1000 != N % 10 * 10 + N % 100 / 10)
    {
        Console.WriteLine("не палиндром");
    }
}

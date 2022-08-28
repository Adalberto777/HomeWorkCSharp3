Console.WriteLine("получаем на вход число пятизначное число и и проверяет, является ли оно палиндромом");

Console.WriteLine("Enter a five-digit number");

string input = Console.ReadLine();
int size = input.Length;

if(size != 5)
{
    Console.WriteLine("It is't a five-digit number");
}
else
{
    if (input[0] == input[4] && input[1] == input[3])
    {
        Console.WriteLine("палиндром");
    }
    if (input[0] != input[4] | input[1] != input[3])
    {
        Console.WriteLine("не палиндром");
    }
}



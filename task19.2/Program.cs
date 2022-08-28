Console.WriteLine("получаем на вход число пятизначное число и и проверяет, является ли оно палиндромом");

Console.WriteLine("Enter a five-digit number");
int number = int.Parse(Console.ReadLine());
int digit = number;
int newnumber = 0;
int dig = 0;

while (digit > 0)
{
    dig = digit % 10;
    newnumber = newnumber * 10 + dig;
    digit = digit / 10;
}

if(newnumber == number)
{
    Console.WriteLine("palindrome");
} 
else
{
    Console.WriteLine("not palindrome");
}
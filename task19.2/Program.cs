Console.WriteLine("получаем на вход число пятизначное число и и проверяет, является ли оно палиндромом");

Console.WriteLine("Enter a five-digit number");
int number = int.Parse(Console.ReadLine());

int digit = number; // временная переменная, что бы сохранить исходное число number
int newnumber = 0; // будующая инвертированная переменная number
int dig = 0;      // временная переменая для откусывания от number последней цифры

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
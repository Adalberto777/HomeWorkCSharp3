Console.WriteLine("получаем на вход число N и выводит кубы чисел от 1 по N включительно");

Console.WriteLine("Enter a integer number");

int N = int.Parse(Console.ReadLine());
int i = 1;

while (i < N + 1)
{
    Console.Write($"{Math.Pow(i,3)},");
    i++;
}

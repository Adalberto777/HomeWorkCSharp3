Console.WriteLine("получаем на вход координаты двух точек, выводим расстояние между ними");

Console.WriteLine("Enter x1");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter y1");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter z1");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter x2");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter y2");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter z2");
double z2 = Convert.ToDouble(Console.ReadLine());

double v = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)); // вычисляем расстояное между точками в трехмерном пространстве

Console.WriteLine($"расстояние между точками - {v}");

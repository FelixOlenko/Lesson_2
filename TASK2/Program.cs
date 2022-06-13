int x = new Random().Next(100,1000);
Console.WriteLine("Целое число:" + x);
int y = int.Parse(x.ToString().Remove(1, 1));
Console.WriteLine("Число без второй цифры:" + y);
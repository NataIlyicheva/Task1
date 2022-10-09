Console.WriteLine("Введите трёхзначное число.");
int Number = int.Parse(Console.ReadLine()!);

int num1 = Number / 10;
int num2 = num1 % 10;

Console.WriteLine(num2);
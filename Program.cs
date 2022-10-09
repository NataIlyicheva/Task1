/* принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа:
456 -> 5,   782 -> 8,   918 -> 1 */

Console.WriteLine("Введите трёхзначное число.");
int Number = int.Parse(Console.ReadLine()!);

int num1 = Number / 10;
int num2 = num1 % 10;

Console.WriteLine(num2);
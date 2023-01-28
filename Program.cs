// Задача 4 * : Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа. Не
//  использовать строки для расчета.
int RandomInt()
{
    Random rnd = new Random();
    return rnd.Next(100, 1000);
}
int number = RandomInt();
int a = number % 10;
int b = number / 100;
int c = b * 10 + a;
System.Console.WriteLine($"случайное число {number}, новое число {c}");

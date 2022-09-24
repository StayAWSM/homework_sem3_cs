Console.Clear();


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void task1()
{
    Console.Clear();
    Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("Введите пятизначное число...");
    int num = Math.Abs(int.Parse(Console.ReadLine() ?? "0")); //Math.Abs() превращает число в скобках в положительное. Хотя скорее всего эта функция работает как модуль.
    int one = num / 10000;
    int two = (num / 1000) % 10;
    int three = (num / 100) % 10;
    int four = (num / 10) % 10;
    int five = num % 10;
    if (num > 9999 && num < 100000)
    {
        if (one == five && two == four) Console.WriteLine("Число является полиндромом.");
        else
        {
            Console.WriteLine("Число не является полиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Число не является пятизначным. Попробуйте заново!");
    }
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void task2()
{
    Console.Clear();
    Console.WriteLine ("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.Write ("Введите координаты x1: ");
    int x1 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты y1: ");
    int y1 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты z1: ");
    int z1 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты x2: ");
    int x2 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты y2: ");
    int y2 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты z2: ");
    int z2 = int.Parse (Console.ReadLine() ?? "0");

    double dist = Math.Round (Math.Sqrt (Math.Pow ((x2 - x1), 2) + Math.Pow ((y2 - y1), 2) + Math.Pow ((z2 - z1), 2)), 2);
    Console.WriteLine("Расстояние: " + dist);
}


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void task3()
{
    Console.Clear();
    Console.WriteLine ("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    Console.Write ("Введите число: ");
    int num = Math.Abs (int.Parse (Console.ReadLine() ?? "0"));
    
    for (int i = 1; i <= num; i++)
    {
        double cube = Math.Pow (i, 3);
        if (i == num) Console.Write(cube);
        else
        {
            Console.Write(cube + ", ");
        }
    }
}


Console.WriteLine ("Введите номер задачи от 1 до 3");
int Num = int.Parse(Console.ReadLine() ?? "0"); //int.Parse тот же Convert.ToInt32, только вроде бы работает быстрее
if (Num == 1) task1();
if (Num == 2) task2();
if (Num == 3) task3();
if (Num != 1 && Num != 2 && Num != 3) Console.WriteLine("Неверное значение. Введите только цифру 1, 2 или 3.");
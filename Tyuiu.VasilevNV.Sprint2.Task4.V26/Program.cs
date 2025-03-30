using Tyuiu.VasilevNV.Sprint2.Task4.V26.Lib;

DataService ds = new DataService();
Console.WriteLine("*Спринт #2 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #2                                                             *");
Console.WriteLine("* Тема: Тернарный оператор                                              *");
Console.WriteLine("* Задание #4                                                            *");
Console.WriteLine("* Вариант #26                                                           *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу, которая вычисляет требуемое значение с использованием*");
Console.WriteLine(" тернарного оператора где пользователь вводит значение x и y             *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("Значение функции -" + res);

Console.ReadLine();

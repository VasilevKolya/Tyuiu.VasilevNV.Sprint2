using Tyuiu.VasilevNV.Sprint2.Task2.V28.Lib;

DataService ds = new DataService();
Console.WriteLine("*Спринт #2 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #2                                                             *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                    *");
Console.WriteLine("* Задание #2                                                            *");
Console.WriteLine("* Вариант #28                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу на, которая запрашивает целые значения с клавиатуры  *");
Console.WriteLine("и вычисляет находится ли точка с координатами X,Y в заштрихованной области.*");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("Введите значение переменной X:                                          *");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной Y:                                          *");
int y = Convert.ToInt32(Console.ReadLine());

bool res = ds.CheckDotInShadedArea(x, y);
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
if (res)
{
    Console.WriteLine("Точка находиться в заштрихованной области");
}
else
{
    Console.WriteLine("Точка не находиться в заштрихованной области");
}
Console.ReadKey();


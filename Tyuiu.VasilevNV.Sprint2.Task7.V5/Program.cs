﻿using Tyuiu.VasilevNV.Sprint2.Task7.V5.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #2 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #2                                                             *");
Console.WriteLine("* Тема:Добавление к решению итоговых проектов по спринту                *");
Console.WriteLine("* Задание #7                                                            *");
Console.WriteLine("* Вариант #5                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу на C#, которая запрашивает исходные данные           *");
Console.WriteLine(" и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.*");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());
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

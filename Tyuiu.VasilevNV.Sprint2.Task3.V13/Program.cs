﻿using Tyuiu.VasilevNV.Sprint2.Task3.V13.Lib;

DataService ds = new DataService();
Console.WriteLine("*Спринт #2 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #2                                                             *");
Console.WriteLine("* Тема: Вложенные операторы if - else                                   *");
Console.WriteLine("* Задание #3                                                            *");
Console.WriteLine("* Вариант #13                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу, которая вычисляет требуемое значение функции Y      *");
Console.WriteLine(" с использованием вложенных оператор if-else, где пользователь          *");
Console.WriteLine("вводит значение переменной X с клавиатуры.                              *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" Введите значение переменной X:                                         *");

double x = Convert.ToDouble(Console.ReadLine());    
double res = ds.Calculate(x);

Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");

Console.WriteLine("Значение функции - " + res);

Console.ReadKey();
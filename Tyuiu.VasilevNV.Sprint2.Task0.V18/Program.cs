﻿using Tyuiu.VasilevNV.Sprint2.Task0.V18.Lib;
using System;
 class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 5105;
        int y = 475;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);
        Console.WriteLine("*Спринт #2 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #2                                                             *");
        Console.WriteLine("* Тема: Операции сравнения                                              *");
        Console.WriteLine("* Задание #0                                                            *");
        Console.WriteLine("* Вариант #18                                                            *");
        Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                               *");
        Console.WriteLine("Написать программу из операций сравнений (==, !=, <, >, <=, >=, "         );
        Console.WriteLine("последовательность операций не должна нарушаться) и арифметических выражений,");
        Console.WriteLine("которая вернет логическую последовательность(массив)                    *");
        Console.WriteLine(" и печатает результат на экране.                                        *");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("*************************************************************************");
        for(int i = 0; i < 6; i++) 
        {
            Console.WriteLine(res[i]);

        
            Console.ReadKey();
    }
}
}

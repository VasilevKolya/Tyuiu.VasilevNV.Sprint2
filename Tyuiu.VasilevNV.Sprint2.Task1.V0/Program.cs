using Tyuiu.VasilevNV.Sprint2.Task1.V10.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 455;
        int b = 335;
        int c = 14;
        int d = 17;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);


        Console.WriteLine("*Спринт #2 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #2                                                             *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
        Console.WriteLine("* Задание #1                                                            *");
        Console.WriteLine("* Вариант #10                                                           *");
        Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                               *");
        Console.WriteLine("Написать программу из операций сравнений и логических операций          *");
        Console.WriteLine("а также арифметических выражений, которая вернет логическую последовательность*");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" a = " + a);
        Console.WriteLine(" b = " + b);
        Console.WriteLine(" c = " + c);
        Console.WriteLine(" d = " + d);
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("*************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();

        }
    }



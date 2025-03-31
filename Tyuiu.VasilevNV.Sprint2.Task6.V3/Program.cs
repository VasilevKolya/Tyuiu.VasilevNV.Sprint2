using Tyuiu.VasilevNV.Sprint2.Task6.V3.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #2 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #2                                                             *");
Console.WriteLine("* Тема:  Получение результата из switch                                 *");
Console.WriteLine("* Задание #6                                                            *");
Console.WriteLine("* Вариант #3                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу, которая использует сокращенную форму записи         *");
Console.WriteLine("оператора switch вычисляет требуемое значение и возвращает результат.   *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" Введите номер недели                                                           *");
int num = Convert.ToInt32(Console.ReadLine());

string res;
if ((num < 1) || (num > 7))
{
    res = "Введенно неверное значение ";
}
else
{
    res = "Это неделя: " + ds.FindDayName(num);
}


Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");

Console.WriteLine(res);
Console.ReadKey();
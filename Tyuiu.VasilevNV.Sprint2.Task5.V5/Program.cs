using Tyuiu.VasilevNV.Sprint2.Task5.V5.Lib;

class Program
{
    static void Main(string[] args)
    {

        DataServie ds = new DataServie();
        Console.WriteLine("*Спринт #2 | Выполнил: Васильев Н. В. | ИСПБ-24-1                     *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #2                                                             *");
        Console.WriteLine("* Тема: Оператор switch                                                 *");
        Console.WriteLine("* Задание #5                                                            *");
        Console.WriteLine("* Вариант #5                                                            *");
        Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                               *");
        Console.WriteLine("Написать программу, которая использует оператор switch                  *");
        Console.WriteLine("вычисляет требуемое значение и возвращает результат.                    *");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" Введите номер карты (6-14)                                             *");
        int numCard = Convert.ToInt32(Console.ReadLine());
        string res;
        if ((numCard < 6) || (numCard > 14))
        {
            res = "Введенно неверное значение!";
        }
        else
        {
            res = "Эта карта:" + ds.FindCardValue(numCard);
        }
                Console.WriteLine("*************************************************************************");
                Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine(res);


                Console.ReadKey();


            }
        }
    



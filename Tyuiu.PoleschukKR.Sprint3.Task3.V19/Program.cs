using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoleschukKR.Sprint3.Task3.V19.Lib;

namespace Tyuiu.PoleschukKR.Sprint3.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Полещук К. Р. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры foreach                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Полещук Кирилл Романович | ИИПб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы x на цифру 2 в строке:            *");
            Console.WriteLine("* sxxrrg x vfrx                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "sxxrrg x vfrx";
            char replaceable = 'x';
            char replacement = '2';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Символ который заменяют: " + replaceable);
            Console.WriteLine("Символ на который заменяют: " + replacement);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Конечная строка: " + ds.ReplaceCharOnNum(value, replaceable,replacement));
            Console.ReadLine();


        }


    }
}

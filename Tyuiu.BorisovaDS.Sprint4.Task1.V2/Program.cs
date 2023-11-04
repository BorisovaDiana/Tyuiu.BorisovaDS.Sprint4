using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorisovaDS.Sprint4.Task1.V2.Lib;

namespace Tyuiu.BorisovaDS.Sprint4.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Борисова Д. C. | ИСТН-б-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Борисова Диана Сергеевна | ИСТН-б-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов массива. С клавиатуры: 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, *");
            Console.WriteLine("* 2                                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");

            foreach (int x in array)
            {
                Console.Write(x + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечетных элементов массива в диапазоне от 1 до 7: " + ds.Calculate(array));


            Console.ReadKey();
        }
    }
}

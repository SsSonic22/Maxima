﻿// See https://aka.ms/new-console-template for more information
namespace MaximaHomeWork
{
    class Lesson5
    {
        static void Main()
        {

            Console.WriteLine("Смотрю что покажу");

            int[,] multy = new int[10, 10];

            MultyTable(multy);

            Console.WriteLine("Вот так вот тоже умею");

        }

        static void MultyTable(int[,] multy)
        {
            // Заполним массив 9 на 9:
            for (int i = 1; i <= 9; i++)
            for (int j = 1; j <= 9; j++)
                multy[i, j] = i * j;

// Выведем элементы многомерного массива 
// Вот эту штучку "\t" я нашла в интернете, это  для выдачи массива в формате таблицы
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(multy[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
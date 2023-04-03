namespace MaximaHomeWork;

public class Lesson6
{
    public double GetPowerNum(int num, int power)
    {
        double num_power = 1;

        for (int i = 0; i < power; i++)
        {
            num_power *= num;
        }

        return num_power;
    }
    public void GetDividers(long num)
    {
        for (var i = 2; i <= num / 2; ++i)
            if (num % i == 0)
                Console.WriteLine($"{i}" + " ");
    }
    public long NumbersCube(long i)
    {
        var iii = i * i * i;
        return iii;
    }
    public long GetHighestFigure(long num)
    {
        long maxima = 0;

        while (num > 0)
        {
            long t = num % 10;
            if (t > maxima)
            {
                maxima = t;
            }

            num = num / 10;
        }

        return maxima;
    }
    public long GetSumm(long num)
    {
        long last = num % 10;
        long first = num;
        while (first > 9)
        {
            first /= 10;
        }

        long sum = first + last;
        return sum;
    }
    public void GetDividers(int i)
    {
        int sum = 0;
        for (int divider = 1; divider <= i - 1; divider++)
        {
            if (i % divider == 0)
            {
                sum += divider;
            }
        }

        if (sum == i)
        {
            Console.WriteLine($"{i}");
        }
    }
    public void MultyTable(int[,] multy)
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
    public void GetEvenUneven(string number)
    {
        long even = 0;
        int uneven = 0;

        foreach (char ch in number)
        {
            int i = (int)ch;
            if (i % 2 == 0)
            {
                even++;
            }
            else if (i % 2 != 0)
            {
                uneven++;
            }
        }
        Console.WriteLine($"Четных чисел {even}, не четных {uneven}");
    }
}

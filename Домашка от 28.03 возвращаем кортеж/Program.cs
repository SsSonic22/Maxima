// See https://aka.ms/new-console-template for more information
class Lesson6
    {
        static void Sorting(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                        (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void Main()
        {
            int[] numbers = {66, -8, 220, 95, -90, 33, 14, 4, 4, 27, -6, 0, 8};
            
            Console.WriteLine("Вывод отсортированного массива");
            Sorting(numbers);
            Console.ReadKey();
        }
    }


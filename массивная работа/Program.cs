using System;

namespace массивная_работа
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] a = new int[23];
            int negCount = 0, evenSum = 0;

            // Заполнение и вывод массива A
            Console.WriteLine("Массив A:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-10, 11);
                Console.Write(a[i] + " ");
                if (a[i] < 0) negCount++;
                if (a[i] % 2 == 0) evenSum += a[i];
            }
            Console.WriteLine($"\nОтрицательных: {negCount}, Четные сумма: {evenSum}");

            int[] b = new int[12];
            double sum6 = 0, sumNeg5 = 0;
            int count6 = 0, countNeg5 = 0;

            // Заполнение и вывод массива B
            Console.WriteLine("\nМассив B:");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rand.Next(-10, 11);
                Console.Write(b[i] + " ");
                if (b[i] > 6)
                {
                    sum6 += b[i];
                    count6++;
                }
                else if (b[i] <= -5)
                {
                    sumNeg5 += b[i];
                    countNeg5++;
                }
            }

            // Средние арифметические
            double avg6 = count6 > 0 ? sum6 / count6 : 0;
            double avgNeg5 = countNeg5 > 0 ? sumNeg5 / countNeg5 : 0;

            Console.WriteLine($"\nСреднее > 6: {avg6}, Среднее <= -5: {avgNeg5}");

            // Новый массив C
            int[] c = new int[32];
            int countMultiplesOf4 = 0;

            // Заполнение массива C случайными числами от -128 до 127
            Console.WriteLine("\nМассив C:");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = rand.Next(-128, 129); // Генерация случайного числа в диапазоне [-128, 127]
                Console.Write(c[i] + " ");
                if (c[i] % 4 == 0) // Проверка на кратность 4
                {
                    countMultiplesOf4++;
                }
            }

            // Вывод результатов для массива C
            Console.WriteLine($"\nКоличество элементов в массиве C, кратных 4: {countMultiplesOf4}");
            Console.WriteLine("Индексы и значения элементов массива C, кратные 4:");
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] % 4 == 0)
                {
                    Console.WriteLine($"Индекс: {i}, Значение: {c[i]}"); // Выводим индексы и значения, кратные 4
                }
            }
        }
    }
}

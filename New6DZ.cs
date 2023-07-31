internal class Program
{
    private static void Main(string[] args)
    {
        void FillArray(int[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
        }
        void FillArrayDouble(double[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
                array[i] = Math.Round(array[i], 2);
            }
        }
        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
        }
        void PrintArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
        }
        int SumPositive(int[] numbers)
        {
            int sumPositive = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) sumPositive += numbers[i];
            }
            return sumPositive;
        }
        int SumNegative(int[] numbers)
        {
            int sumNegative = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0) sumNegative += numbers[i];
            }
            return sumNegative;
        }
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }



        void Task41()
        {
            //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

            int countOfNumbers = Input("Сколько чисел хотите ввести? ");
            int count = 0;
            for (int i = 1; i <= countOfNumbers; i++)
            {
                int number = Input($"Введите {i} число: ");
                if (number > 0) count++;

            }
            Console.WriteLine($"Вы ввели {count} чисел больше нуля");
        }
        //Task41();

        void Task43()
        {
            // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

            // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

            int k1 = Input("k1: ");
            int b1 = Input("b1: ");
            int k2 = Input("k2: ");
            int b2 = Input("b2: ");

            double x = (b2 - b1)/(k1 - k2);
            double y1 = k1 * x + b1;
            double y2 = k2 * x + b2;
            Console.WriteLine($"A({x}, {y1})");
            Console.WriteLine($"A({x}, {y2})");
        }
        Console.Clear();
        Task43();

        

    }
}
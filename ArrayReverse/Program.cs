using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем исходный массив с заранее определенными значениями
            int[] originalArray = { 10, 20, 30, 40, 50 };

            // 2. Выводим исходный массив на экран в одну строку
            Console.Write("Исходный массив: ");
            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.Write(originalArray[i] + " ");
            }
            Console.WriteLine();

            // 3. Создаем новый массив такого же размера
            int[] reversedArray = new int[originalArray.Length];

            // 4. Заполняем новый массив элементами исходного в обратном порядке
            // Используем "хитрую формулу": индекс в новом массиве = длина - 1 - индекс в старом
            for (int i = 0; i < originalArray.Length; i++)
            {
                reversedArray[i] = originalArray[originalArray.Length - 1 - i];
            }

            // 5. Выводим перевернутый массив на экран в одну строку
            Console.Write("Перевернутый массив: ");
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
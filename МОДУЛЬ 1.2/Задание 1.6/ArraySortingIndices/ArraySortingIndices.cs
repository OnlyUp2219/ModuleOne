using System;

namespace ArraySortingIndices
{
   internal class ArraySortingIndices
   {
      static void Main(string[] args)
      {
         ArraySortingIndices sortingIndices = new ArraySortingIndices();
         sortingIndices.Start();
      }

      #region Основная логика

      /// <summary>
      /// Метод для запуска программы
      /// </summary>
      private void Start()
      {
         // Создание массива из 10 элементов с случайными значениями
         double[] array = GenerateRandomArray(10, -10, 10);

         // Вывод исходного массива
         Console.WriteLine("Исходный массив:");
         PrintArray(array);

         // Создание массива индексов, отсортированных по возрастанию значений исходного массива
         int[] indexArray = GetSortedIndices(array);

         // Вывод массива индексов
         Console.WriteLine("Массив индексов, сортирующий элементы по возрастанию:");
         PrintArray(indexArray);

         // Вывод элементов исходного массива по отсортированным индексам
         Console.WriteLine("Массив, отсортированный по значениям:");
         for (int i = 0; i < indexArray.Length; i++)
         {
            Console.Write("{0:0.###} ", array[indexArray[i]]);
         }
      }

      #endregion

      #region Генерация случайного массива

      /// <summary>
      /// Метод для генерации случайного вещественного массива в заданном диапазоне
      /// </summary>
      /// <param name="length">Длина массива</param>
      /// <param name="min">Минимальное значение диапазона</param>
      /// <param name="max">Максимальное значение диапазона (не включительно)</param>
      /// <returns>Массив случайных вещественных чисел</returns>
      private double[] GenerateRandomArray(int length, double min, double max)
      {
         double[] array = new double[length];
         Random random = new Random();

         // Заполнение массива случайными значениями в заданном диапазоне
         for (int i = 0; i < length; i++)
         {
            array[i] = random.NextDouble() * (max - min) + min; // Генерация случайных чисел в диапазоне [min, max)
         }

         return array;
      }

      #endregion

      #region Получение массива индексов

      /// <summary>
      /// Метод для получения массива индексов, отсортированных по значениям исходного массива
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <returns>Массив индексов, сортирующих элементы по возрастанию</returns>
      private int[] GetSortedIndices(double[] array)
      {
         // Массив индексов от 0 до длины массива
         int[] indices = new int[array.Length];
         for (int i = 0; i < indices.Length; i++)
         {
            indices[i] = i;
         }

         // Сортировка индексов на основе значений исходного массива
         Array.Sort(indices, (a, b) => array[a].CompareTo(array[b]));

         return indices;
      }

      #endregion

      #region Вывод массива

      /// <summary>
      /// Метод для вывода массива чисел
      /// </summary>
      /// <param name="array">Массив для вывода</param>
      private void PrintArray(double[] array)
      {
         foreach (double value in array)
         {
            Console.Write("{0:0.###} ", value);
         }
         Console.WriteLine();
      }

      /// <summary>
      /// Метод для вывода массива индексов
      /// </summary>
      /// <param name="array">Массив для вывода</param>
      private void PrintArray(int[] array)
      {
         foreach (int value in array)
         {
            Console.Write(value + " ");
         }
         Console.WriteLine();
      }

      #endregion
   }
}

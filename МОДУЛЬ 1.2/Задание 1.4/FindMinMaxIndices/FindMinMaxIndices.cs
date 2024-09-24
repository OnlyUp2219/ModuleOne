namespace FindMinMaxIndices
{
   internal class FindMinMaxIndices
   {
      static void Main(string[] args)
      {
         FindMinMaxIndices findMinMaxIndices = new FindMinMaxIndices();
         findMinMaxIndices.Start();
      }

      #region Основная логика

      /// <summary>
      /// Основной метод для запуска программы
      /// </summary>
      private void Start()
      {
         int[] array = Array.Empty<int>();

         // Ввод размера массива
         Console.WriteLine("Введите размер массива!");
         array = SetLenghtArray(array);

         // Заполнение элементов массива случайными значениями
         Console.WriteLine("Массив заполнен!");
         array = SetRandomElemArray(array);

         // Получение индекса максимального и минимального элемента
         int maxElem = GetMaxElemIndex(array);
         int minElem = GetMinElemIndex(array);

         // Вывод оригинального массива
         Print(array);

         // Печать максимального и минимального элемента
         Console.WriteLine(maxElem + " - индекс первого максимального элемента");
         Console.WriteLine(minElem + " - индекс первого минимального элемента");

         // Вывод измененного массива
         Print(array, minElem, maxElem);
      }

      #endregion

      #region Получение индекса максимального и минимального элемента

      /// <summary>
      /// Метод для нахождения индекса максимального элемента
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <returns>Индекс максимального элемента</returns>
      private int GetMinElemIndex(int[] array)
      {
         int maxIndex = 0;
         int maxEl = array[0]; // Инициализация максимального элемента первым значением массива

         for (int i = 1; i < array.Length; i++)
         {
            // Проверка на максимальное значение
            if (array[i] > maxEl)
            {
               maxEl = array[i];
               maxIndex = i;
            }
         }
         return maxIndex;
      }


      /// <summary>
      /// Метод для нахождения индекса минимального элемента
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <returns>Индекс минимального элемента</returns>
      private int GetMaxElemIndex(int[] array)
      {
         int minIndex = 0;
         int minEl = array[0]; // Инициализация минимального элемента первым значением массива

         for (int i = 1; i < array.Length; i++)
         {
            // Проверка на максимальное значение
            if (array[i] < minEl)
            {
               minEl = array[i];
               minIndex = i;
            }
         }
         return minIndex;
      }

      #endregion

      #region Ввод, вывод, инициализация массива

      /// <summary>
      /// Метод для вывода части массива в консоль
      /// </summary>
      /// <param name="array">Массив для вывода</param>
      /// <param name="minIndex">Минимальный индекс для вывода (по умолчанию 0)</param>
      /// <param name="maxIndex">Максимальный индекс для вывода (по умолчанию равен длине массива)</param>
      private void Print(int[] array, int minIndex = 0, int maxIndex = -1)
      {
         // Если maxIndex не задан, устанавливаем его равным длине массива
         if (maxIndex == -1)
         {
            maxIndex = array.Length;
         }

         // Убедимся, что индексы в пределах массива
         int i = Math.Max(0, Math.Min(minIndex, maxIndex));   // Минимум всегда должен быть >= 0
         int j = Math.Min(array.Length, Math.Max(minIndex, maxIndex));   // Максимум не больше длины массива

         // Вывод каждого элемента массива от i до j
         for (; i < j; i++)
         {
            Console.Write(array[i] + " ");
         }
         Console.WriteLine(); // Переход на новую строку для корректного вывода
      }

      /// <summary>
      /// Метод для заполнения массива случайными элементами
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <returns>Заполненный массив случайными числами</returns>
      private int[] SetRandomElemArray(int[] array)
      {
         Random random = new Random();

         for (int i = 0; i < array.Length; i++)
         {
            int randEl = random.Next(1, 10); // Генерация случайного числа от 1 до 10
            array[i] = randEl;
         }
         return array;
      }

      /// <summary>
      /// Метод для задания длины массива
      /// </summary>
      /// <param name="array">Пустой массив</param>
      /// <returns>Массив с заданной длиной</returns>
      private int[] SetLenghtArray(int[] array)
      {
         // Ввод длины массива с проверкой
         int.TryParse(Console.ReadLine(), out int length);
         array = new int[length];
         return array;
      }

      #endregion

   }
}

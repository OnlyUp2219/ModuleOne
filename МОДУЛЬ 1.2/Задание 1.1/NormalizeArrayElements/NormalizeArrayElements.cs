namespace NormalizeArrayElements
{
   internal class NormalizeArrayElements
   {
      static void Main(string[] args)
      {
         // Создание экземпляра класса и запуск программы
         NormalizeArrayElements normalizeArrayElements = new NormalizeArrayElements();
         normalizeArrayElements.Start();
      }

      #region Основная логика

      /// <summary>
      /// Основной метод для запуска программы
      /// </summary>
      private void Start()
      {
         double[] array = Array.Empty<double>();

         // Ввод размера массива
         Console.WriteLine("Введите размер массива!");
         array = SetLenghtArray(array);

         // Ввод элементов массива
         Console.WriteLine("Заполните массив!");
         array = SetElemArray(array);

         // Получение максимального по модулю элемента
         double maxElem = GetMaxElemAbs(array);

         // Вывод оригинального массива
         Print(array);

         // Нормализация элементов массива
         array = Normalize(array, maxElem);

         // Вывод нормализованного массива
         Print(array);
      }

      #endregion

      #region Нормализация массива

      /// <summary>
      /// Метод для нормализации элементов массива
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <param name="max">Максимальное значение по модулю</param>
      /// <returns>Нормализованный массив</returns>
      private double[] Normalize(double[] array, double max)
      {
         for (int i = 0; i < array.Length; i++)
         {
            // Нормализация каждого элемента
            array[i] = array[i] / max;
         }
         return array;
      }

      #endregion

      #region Получить максимальный элемент по модулю

      /// <summary>
      /// Метод для нахождения максимального по модулю элемента массива
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <returns>Максимальный элемент по модулю</returns>
      private double GetMaxElemAbs(double[] array)
      {
         int i = 0;
         double maxEl = array[0]; // Инициализация максимального элемента первым значением массива

         for (; i < array.Length; i++)
         {
            // Проверка на максимальное значение по модулю
            if (Math.Abs(array[i]) > Math.Abs(maxEl))
            {
               maxEl = array[i];
            }
         }
         return maxEl;
      }

      #endregion

      #region Ввод, вывод, инициализация массива

      /// <summary>
      /// Метод для вывода массива в консоль
      /// </summary>
      /// <param name="array">Массив для вывода</param>
      private void Print(double[] array)
      {
         // Вывод каждого элемента массива
         foreach (double i in array)
         {
            Console.Write(i + " ");
         }
         Console.WriteLine(); // Переход на новую строку для корректного вывода
      }

      /// <summary>
      /// Метод для заполнения массива элементами
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <returns>Заполненный массив</returns>
      private double[] SetElemArray(double[] array)
      {
         for (int i = 0; i < array.Length; i++)
         {
            Console.Write($"array[{i}] = ");
            double el;
            // Попытка преобразования ввода пользователя в число
            double.TryParse(Console.ReadLine(), out el);
            array[i] = el;
         }
         return array;
      }

      /// <summary>
      /// Метод для задания длины массива
      /// </summary>
      /// <param name="array">Пустой массив</param>
      /// <returns>Массив с заданной длиной</returns>
      private double[] SetLenghtArray(double[] array)
      {
         // Ввод длины массива с проверкой
         int.TryParse(Console.ReadLine(), out int length);
         array = new double[length];
         return array;
      }

      #endregion
   }
}

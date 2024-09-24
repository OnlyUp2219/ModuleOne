namespace ReplaceMaximum
{
   internal class ReplaceMaximum
   {
      static void Main(string[] args)
      {
         // Создание экземпляра класса и запуск программы
         ReplaceMaximum replaceMaximum = new ReplaceMaximum();
         replaceMaximum.Start();
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

         // Получение индекса максимального элемента
         int maxElem = GetMaxElemIndex(array);

         // Вывод оригинального массива
         Print(array);

         // Печать максимального элемента
         Console.WriteLine(array[maxElem] + " - первый максимальный элемент");

         // Замена максимального элемента введенным числом
         Console.WriteLine("Введите число: ");
         array = ReplaceMax(array, maxElem);

         // Вывод измененного массива
         Print(array);
      }

      #endregion

      #region Получение индекса максимального элемента

      /// <summary>
      /// Метод для нахождения индекса максимального элемента
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <returns>Индекс максимального элемента</returns>
      private int GetMaxElemIndex(int[] array)
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

      #endregion

      #region Ввод, вывод, инициализация массива

      /// <summary>
      /// Метод для вывода массива в консоль
      /// </summary>
      /// <param name="array">Массив для вывода</param>
      private void Print(int[] array)
      {
         // Вывод каждого элемента массива
         foreach (int i in array)
         {
            Console.Write(i + " ");
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

      #region Замена максимального элемента

      /// <summary>
      /// Метод для замены максимального элемента в массиве на введенное число
      /// </summary>
      /// <param name="array">Исходный массив</param>
      /// <param name="maxElem">Индекс максимального элемента</param>
      /// <returns>Массив с замененным максимальным элементом</returns>
      private int[] ReplaceMax(int[] array, int maxElem)
      {
         // Ввод числа для замены
         int.TryParse(Console.ReadLine(), out int number);

         // Замена максимального элемента введенным числом
         array[maxElem] = number;

         return array;
      }

      #endregion
   }
}

namespace GeneratePrimeNumbers
{
   internal class GeneratePrimeNumbers
   {
      static void Main(string[] args)
      {
         // Создание экземпляра класса и запуск программы
         GeneratePrimeNumbers generatePrimeNumbers = new GeneratePrimeNumbers();
         generatePrimeNumbers.Start();
      }

      #region Основная логика

      /// <summary>
      /// Основной метод для запуска программы
      /// </summary>
      private void Start()
      {
         // Ввод количества простых чисел
         Console.WriteLine("Введите количество простых чисел (K): ");
         int k = int.Parse(Console.ReadLine());

         // Поиск первых K простых чисел
         List<int> primes = CalculatePrimes(k);

         // Вывод чисел по 10 на строке
         PrintPrimes(primes);
      }

      #endregion

      #region Поиск простых чисел

      /// <summary>
      /// Метод для вычисления первых K простых чисел
      /// </summary>
      /// <param name="k">Количество простых чисел</param>
      /// <returns>Список первых K простых чисел</returns>
      private List<int> CalculatePrimes(int k)
      {
         List<int> primes = new List<int>();
         int number = 2; // Начинаем с первого простого числа

         // Цикл продолжается, пока не найдено K простых чисел
         while (primes.Count < k)
         {
            if (IsPrime(number))
            {
               primes.Add(number); // Добавление простого числа в список
            }
            number++;
         }

         return primes;
      }

      /// <summary>
      /// Метод для проверки, является ли число простым
      /// </summary>
      /// <param name="number">Число для проверки</param>
      /// <returns>True, если число простое, иначе False</returns>
      private bool IsPrime(int number)
      {
         // Проверка делимости на числа от 2 до корня из числа
         for (int i = 2; i <= Math.Sqrt(number); i++)
         {
            if (number % i == 0)
            {
               return false; // Если делится без остатка, то число не простое
            }
         }
         return true; // Если делителей нет, то число простое
      }

      #endregion

      #region Вывод простых чисел

      /// <summary>
      /// Метод для вывода простых чисел по 10 на строке
      /// </summary>
      /// <param name="primes">Список простых чисел</param>
      private void PrintPrimes(List<int> primes)
      {
         int count = 0;

         // Проход по каждому простому числу в списке
         foreach (int prime in primes)
         {
            Console.Write(prime + " ");
            count++;

            // Переход на новую строку после каждых 10 чисел
            if (count % 10 == 0)
            {
               Console.WriteLine();
            }
         }

         // Если не было кратного 10 вывода, то добавляем переход на новую строку
         if (count % 10 != 0)
         {
            Console.WriteLine();
         }
      }

      #endregion
   }
}

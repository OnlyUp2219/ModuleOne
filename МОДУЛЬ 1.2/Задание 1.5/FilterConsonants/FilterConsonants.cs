namespace FilterConsonants
{
   internal class FilterConsonants
   {
      static void Main(string[] args)
      {
         FilterConsonants filterConsonants = new FilterConsonants();
         filterConsonants.Start();
      }

      #region Основная логика

      /// <summary>
      /// Метод для запуска программы
      /// </summary>
      private void Start()
      {
         // Ввод длины массива
         Console.WriteLine("Введите количество элементов в массиве:");
         int k;
         int.TryParse(Console.ReadLine(), out k);

         // Инициализация массива символов
         char[] charArray = GenerateRandomCharArray(k);

         // Вывод исходного массива
         Console.WriteLine("Исходный массив:");
         PrintArray(charArray);

         // Создание массива согласных
         char[] consonantArray = ExtractConsonants(charArray);

         // Вывод массива согласных
         Console.WriteLine("Массив согласных:");
         PrintArray(consonantArray);
      }

      #endregion

      #region Генерация массива

      /// <summary>
      /// Метод для генерации случайного массива символов русского алфавита
      /// </summary>
      /// <param name="length">Длина массива</param>
      /// <returns>Массив случайных букв русского алфавита</returns>
      private char[] GenerateRandomCharArray(int length)
      {
         char[] array = new char[length];
         Random random = new Random();

         // Русские буквы: диапазон от 'а' до 'я'
         for (int i = 0; i < length; i++)
         {
            // Генерация случайного символа
            array[i] = (char)random.Next('а', 'я' + 1); // Генерация букв в диапазоне русского алфавита
         }

         return array;
      }

      #endregion

      #region Вывод массива

      /// <summary>
      /// Метод для вывода массива символов в консоль
      /// </summary>
      /// <param name="array">Массив для вывода</param>
      private void PrintArray(char[] array)
      {
         foreach (char c in array)
         {
            Console.Write(c + " ");
         }
         Console.WriteLine();
      }

      #endregion

      #region Фильтрация согласных

      /// <summary>
      /// Метод для извлечения согласных букв из массива
      /// </summary>
      /// <param name="array">Исходный массив символов</param>
      /// <returns>Массив, содержащий только согласные буквы</returns>
      private char[] ExtractConsonants(char[] array)
      {
         // Список согласных букв русского алфавита
         char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };

         // Временный список для хранения согласных
         List<char> consonantList = new List<char>();

         // Фильтрация массива для извлечения согласных букв
         foreach (char c in array)
         {
            if (Array.Exists(consonants, consonant => consonant == c))
            {
               consonantList.Add(c); // Добавляем только согласные
            }
         }

         return consonantList.ToArray();
      }

      #endregion
   }
}

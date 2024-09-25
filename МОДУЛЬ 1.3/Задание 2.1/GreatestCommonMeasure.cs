using System;

namespace GreatestCommonMeasure
{
   internal class GreatestCommonMeasure
   {
      static void Main(string[] args)
      {
         GreatestCommonMeasure greatestCommonMeasure = new GreatestCommonMeasure();

         // Ввод дроби от пользователя
         Console.WriteLine("Введите дробь в виде неотрицательного числителя и положительного знаменателя (пример 36/48)");
         string? strValue = Console.ReadLine();

         // Преобразование введенной дроби в числитель и знаменатель
         int[] intValues = greatestCommonMeasure.GetValueFromFraction(strValue);

         // Вычисление НОД (наибольшего общего делителя)
         int GCD = FindGCD(intValues[0], intValues[1]);
         Console.WriteLine($"НОД = {GCD}");

         // Сокращение дроби
         string ReducedFraction = greatestCommonMeasure.GetReducedFraction(intValues, GCD);
         Console.WriteLine("Сокращенная дробь: " + ReducedFraction);
      }

      #region Преобразование дроби

      /// <summary>
      /// Метод для сокращения дроби с использованием НОД.
      /// </summary>
      /// <param name="intValues">Массив с числителем и знаменателем</param>
      /// <param name="GCD">Наибольший общий делитель</param>
      /// <returns>Сокращенная дробь в виде строки</returns>
      private string GetReducedFraction(int[] intValues, int GCD)
      {
         for (int i = 0; i < intValues.Length; i++)
         {
            intValues[i] = intValues[i] / GCD;
         }
         return $"{intValues[0]}/{intValues[1]}";
      }

      #endregion

      #region Парсинг строки дроби

      /// <summary>
      /// Метод для извлечения числителя и знаменателя из строки вида "числитель/знаменатель".
      /// </summary>
      /// <param name="strValue">Введенная пользователем строка</param>
      /// <returns>Массив, где [0] - числитель, [1] - знаменатель</returns>
      private int[] GetValueFromFraction(string strValue)
      {
         string[] values = strValue.Split('/', StringSplitOptions.RemoveEmptyEntries);
         int[] intValues = new int[2];
         for (int i = 0; i < 2; i++)
         {
            int.TryParse(values[i], out int intValue);
            intValues[i] = intValue;
         }
         return intValues;
      }

      #endregion

      #region НОД (Наибольший общий делитель)

      /// <summary>
      /// Метод для нахождения наибольшего общего делителя (НОД) двух чисел.
      /// Используется рекурсивный алгоритм Евклида.
      /// </summary>
      /// <param name="a">Первое число</param>
      /// <param name="b">Второе число</param>
      /// <returns>Наибольший общий делитель</returns>
      static int FindGCD(int a, int b)
      {
         while (true)
         {
            if (a == 0 || b == 0)
            {
               return a + b;
            }
            if (a > b)
            {
               return FindGCD(a - b, b);
            }
            else
            {
               return FindGCD(a, b - a);
            }
         }
      }

      #endregion
   }
}

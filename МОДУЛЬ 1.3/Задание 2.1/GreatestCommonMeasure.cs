/*
   Определить функцию(статический метод) для вычисления наибольшего общего делителя двух целых натуральных чисел (Greatest Common Measure). 
  В основной программе, используя функцию, сократить неотрицательную обыкновенную дробь. 
  Дробь вводится с клавиатуры в виде неотрицательного числителя и положительного знаменателя
*/



using System;

namespace GreatestCommonMeasure
{
   internal class GreatestCommonMeasure
   {
      static void Main(string[] args)
      {
         GreatestCommonMeasure greatestCommonMeasure = new GreatestCommonMeasure();
         Console.WriteLine("Введите дробь в виде неотрицательного числителя и положительного знаменателя  (пример 36/48)");
         string? strValue = Console.ReadLine();
         int[] intValues = greatestCommonMeasure.GetValueFromFraction(strValue);
         int GCD = FindGCD(intValues[0], intValues[1]);
         Console.WriteLine($"НОД = {GCD}");
         string ReducedFraction = greatestCommonMeasure.GetReducedFraction(intValues, GCD);
         Console.WriteLine("Сокращенная дробь " + ReducedFraction);
      }

      private string GetReducedFraction(int[] intValues, int GCD)
      {
         for (int i = 0; i < intValues.Length; i++)
         {
            intValues[i] = intValues[i] / GCD;
         }


         return $"{intValues[0]}/{intValues[1]}";
      }

      private int[] GetValueFromFraction(string strValue)
      {
         string[] values = (strValue.Split('/', StringSplitOptions.RemoveEmptyEntries));
         int[] intValues = new int[2];
         for (int i = 0; i < 2; i++)
         {
            int.TryParse(values[i], out int intValue);
            intValues[i] = intValue;
         }
         return intValues;
      }

      #region НОД
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

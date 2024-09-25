using System;
using System.Collections.Generic;

namespace MinElementSumArray
{
   internal class MinElementSumArray
   {
      static void Main(string[] args)
      {
         MinElementSumArray minElementSumArray = new MinElementSumArray();
         minElementSumArray.Start();
      }

      #region Старт программы
      /// <summary>
      /// Старт программы. Ввод числа от пользователя и создание массива.
      /// </summary>
      private void Start()
      {
         Console.WriteLine("Введите число!");
         int value;
         int.TryParse(Console.ReadLine(), out value); // Преобразование строки в число
         List<int> list = FillArrayWithLimit(value);  // Заполнение массива
         Console.WriteLine("Массив: ");
         Print(list);  // Вывод массива
      }
      #endregion

      #region Заполнение массива
      /// <summary>
      /// Заполняет массив случайными числами от 1 до 9, 
      /// пока их сумма не превысит заданное пользователем число.
      /// </summary>
      /// <param name="value">Максимальная допустимая сумма элементов массива</param>
      /// <returns>Массив чисел</returns>
      private List<int> FillArrayWithLimit(int value)
      {
         List<int> list = new List<int>();  // Инициализация пустого списка
         Random random = new Random();  // Генератор случайных чисел
         int currentSum = 0;  // Текущая сумма элементов массива

         // Заполняем массив до тех пор, пока сумма элементов не превысит заданное значение
         for (int i = 0; i < value; i++)
         {
            int rndValue = random.Next(1, 10);  // Случайное число от 1 до 9
            if (currentSum + rndValue <= value) // Если текущая сумма с новым числом не превышает лимит
            {
               currentSum += rndValue;  // Добавляем значение к сумме
               list.Add(rndValue);      // Добавляем элемент в массив
            }
            else
               return list;  // Если сумма превышена, возвращаем текущий массив
         }
         return list;
      }
      #endregion

      #region Вывод массива
      /// <summary>
      /// Печатает элементы списка в консоль.
      /// </summary>
      /// <param name="list">Список чисел для вывода</param>
      private void Print(List<int> list)
      {
         Console.Write("[ ");
         foreach (int i in list)
         {
            Console.Write(i + " ");  // Выводим каждый элемент массива
         }
         Console.WriteLine("]");
      }
      #endregion
   }
}

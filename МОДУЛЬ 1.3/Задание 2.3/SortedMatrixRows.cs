using System;

namespace SortedMatrixRows
{
   internal class SortedMatrixRows
   {
      static void Main(string[] args)
      {
         SortedMatrixRows sortedMatrixRows = new SortedMatrixRows();
         sortedMatrixRows.Start();
      }

      private void Start()
      {
         // Ввод размерности квадратной матрицы
         Console.WriteLine("Введите размерность квадратной матрицы: ");
         int matrixCount = 0;
         int.TryParse(Console.ReadLine(), out matrixCount);

         // Создание матрицы и заполнение её случайными значениями
         int[,] matrix = new int[matrixCount, matrixCount];
         matrix = SetElementMatrix(matrix);

         // Вывод исходной матрицы
         Console.WriteLine("Матрица: ");
         Print(matrix);

         // Вывод суммы строк до сортировки
         GetValueSumRows(matrix);

         // Сортировка матрицы по сумме строк
         matrix = GetSortMatrixByRowSum(matrix);

         // Вывод изменённой матрицы
         Console.WriteLine("Измененная матрица: ");
         Print(matrix);

         // Вывод суммы строк после сортировки
         GetValueSumRows(matrix);
      }

      #region Методы ввода/вывода

      // Метод для печати матрицы
      private void Print(int[,] matrix)
      {
         Console.WriteLine("[");
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
            Console.Write("[");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine("]");
         }
         Console.Write("]");
         Console.WriteLine();
      }

      // Метод для вывода суммы каждой строки матрицы
      private void GetValueSumRows(int[,] matrix)
      {
         int sum = 0;
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               sum += matrix[i, j];
            }
            Console.WriteLine($"Сумма строки[{i}] = {sum}");
            sum = 0; // Сбрасываем сумму для следующей строки
         }
      }

      #endregion

      #region Методы для работы с матрицей

      // Метод для заполнения матрицы случайными значениями
      private int[,] SetElementMatrix(int[,] matrix)
      {
         Random random = new Random();
         for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
               matrix[i, j] = random.Next(-50, 51); // Диапазон от -50 до 50

         return matrix;
      }

      // Метод для получения суммы строк матрицы
      private int[] GetSumRows(int[,] matrix)
      {
         int[] sumUnsorted = new int[matrix.GetLength(0)];
         int sum = 0;
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               sum += matrix[i, j];
            }
            sumUnsorted[i] = sum; // Сохраняем сумму строки
            sum = 0; // Сбрасываем сумму для следующей строки
         }
         return sumUnsorted;
      }

      #endregion

      #region Методы сортировки

      // Метод для сортировки строк матрицы по возрастанию сумм их элементов
      private int[,] GetSortMatrixByRowSum(int[,] matrix)
      {
         int size = matrix.GetLength(0);
         int[] rowSums = GetSumRows(matrix);
         // Сортировка строк матрицы по суммам
         for (int i = 0; i < size - 1; i++)
         {
            for (int j = i + 1; j < size; j++)
            {
               // Сравниваем суммы строк
               if (rowSums[i] > rowSums[j])
               {
                  // Меняем местами строки и их суммы
                  matrix = GetSwapRows(matrix, i, j);
                  int temp = rowSums[i];
                  rowSums[i] = rowSums[j];
                  rowSums[j] = temp;
               }
            }
         }
         return matrix;
      }

      // Метод для обмена двух строк матрицы
      private int[,] GetSwapRows(int[,] matrix, int row1, int row2)
      {
         int size = matrix.GetLength(0);
         for (int j = 0; j < size; j++)
         {
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
         }
         return matrix;
      }

      #endregion
   }
}

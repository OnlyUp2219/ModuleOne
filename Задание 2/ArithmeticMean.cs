namespace ArithmeticMean
{
   internal class ArithmeticMean
   {
      static void Main(string[] args)
      {
         ArithmeticMean arithmeticMean = new ArithmeticMean();
         arithmeticMean.Start();
      }

      #region Точка входа в программу
      private void Start()
      {
         Console.WriteLine("Введите массив");
         int[] array = InputArray(3);
         Console.WriteLine($"Среднее арифмитическое: {ArithmeticMeanNumbers(array)}");

      }
      #endregion

      #region Ввод массива
      private int[] InputArray(int count)
      {
         int[] array = new int[count];
         int number;
         for (int i = 0; i < count; i++)
         {
            int.TryParse(Console.ReadLine(), out number);
            array[i] = number;
         }
         return array;
      }
      #endregion

      #region Среднее арифмитическое 
      private float ArithmeticMeanNumbers(int[] array)
      {
         int sum = 0;
         foreach (int i in array)
            sum += i;
         float mean = sum / array.Length;
         return mean;
      }
      #endregion
   }
}
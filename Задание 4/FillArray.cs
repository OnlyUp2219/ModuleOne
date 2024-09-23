namespace FillArray
{
   internal class FillArray
   {
      static void Main(string[] args)
      {
         FillArray fillArray = new FillArray();
         fillArray.Start();
      }


      #region Точка входа в программу
      private void Start()
      {
         int[] array = FillingArrayRandomNumbers(10);
         Console.WriteLine("Массив заполнен!");
         Console.WriteLine("Вывод массива: ");
         Print(array);
         Console.WriteLine($"Сумма чисел массива равна: {SumArray(array)}");
      }
      #endregion


      #region Заполнение массива рандомными числами
      private int[] FillingArrayRandomNumbers(int count)
      {
         Random rnd = new Random();
         int [] numbers = new int[count]; 
         for (int i = 0; i < numbers.Length; i++) 
         {
            numbers[i] = rnd.Next(1, 10);
         }
         return numbers;
      }
      #endregion

      #region Вывод массива
      private void Print(int[] array)
      {
         foreach (int i in array)
            Console.Write(i + " ");
         Console.WriteLine();
      }
      #endregion

      #region Сумма элементов массива
      private int SumArray(int[] array)
      {
         int sum = 0;
         foreach (var i in array)
         {
            sum += i;
         }
         return sum;    
      }
      #endregion

   }
}

namespace NormalizeArrayElements
{
   internal class NormalizeArrayElements
   {
      static void Main(string[] args)
      {
         NormalizeArrayElements normalizeArrayElements = new NormalizeArrayElements();
         normalizeArrayElements.Start();
      }

      private void Start()
      {
         double[] array = Array.Empty<double>();
         Console.WriteLine("Введите размер массива!");
         array = SetLenghtArray(array);
         Console.WriteLine("Заполните массив!");
         array = SetElemArray(array);
         double maxElem = GetMaxElemAbs(array);
         Print(array);
         array = Normalize(array, maxElem);
         Print(array);
      }

      private double[] Normalize(double[] array, double max)
      {
         for(int i = 0; i < array.Length; i++) 
         {
            array[i] = array[i] / max;
         }
         return array;
      }

      private double GetMaxElemAbs(double[] array)
      {
         int i = 0;
         double maxEl = array[0];
         for (; i < array.Length; i++)
         {
            if (Math.Abs(array[i]) > Math.Abs(maxEl))
            {
               maxEl = array[i];
            }
         }
         return maxEl;
      }

      private void Print(double[] array)
      {
         foreach (double i in array)
         {
            Console.Write(i + " ");
         }
      }

      private double[] SetElemArray(double[] array)
      {
         for (int i = 0; i < array.Length; i++)
         {
            Console.Write($"array[{i}] = ");
            double el;
            double.TryParse(Console.ReadLine(), out el);
            array[i] = el;
         }
         return array;
      }

      private double[] SetLenghtArray(double[] array)
      {
         int.TryParse(Console.ReadLine(), out int length);
         array = new double[length];
         return array;
      }

   }
}

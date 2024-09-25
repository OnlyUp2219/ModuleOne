/*
Присваивая последовательным элементам массива случайные значения от 1 до 9, 
создать массив с минимальным количеством элементов, 
сумма которых не превышает заданного пользователем числа.
*/


namespace MinElementSumArray
{
   internal class MinElementSumArray
   {
      static void Main(string[] args)
      {
         MinElementSumArray minElementSumArray = new MinElementSumArray();
         minElementSumArray.Start();

      }

      private void Start()
      {
         Console.WriteLine("Введите число!");
         int value;
         int.TryParse(Console.ReadLine(), out value);
         List<int> list = FillArrayWithLimit(value);
         Console.WriteLine("Массив: ");
         Print(list);
      }

      private List<int> FillArrayWithLimit(int value)
      {
         List<int> list = new List<int>();
         Random random = new Random();
         int currentSum = 0; // Текущая сумма элементов массива
         for (int i = 0; i < value; i++)
         {
            int rndValue = random.Next(1, 10);
            if (currentSum <= value)
            {
               currentSum += rndValue;
               list.Add(rndValue);
            }
            else
               return list;
         }
         return list;
      }

      private void Print(List<int> list)
      {
            Console.Write("[ ");
         foreach (int i in list)
         {
                Console.Write(i + " ");
         }
         Console.WriteLine("]");
      }


   }
}

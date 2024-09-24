namespace GuessNumber
{
   internal class GuessNumber
   {
      static void Main(string[] args)
      {
         GuessNumber search = new GuessNumber();
         search.Start();
      }

      bool isRightAnswer = false;

      #region Точка запуска программы
      private void Start()
      {
         int random = RandomNumber();
         while (!isRightAnswer)
         {
            int number;
            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out number);
            isRightAnswer = isGuessNumber(number, random);
         }
         Console.WriteLine("Конец приложения!");
      }
      #endregion

      #region Рандомное число
      private int RandomNumber()
      {
         Random random = new Random();
         int number = random.Next(1, 100);
         return number;
      }
      #endregion

      #region Отгадывание числа
      private bool isGuessNumber(int number, int randomNumber)
      {
         if (number == randomNumber)
         {
            Console.WriteLine($"Вы угадали чиcло это {randomNumber}");
            return true;
         }
         else if (number > randomNumber)
         {
            Console.WriteLine($"Число меньше заданного");
            return false;
         }
         else if (number < randomNumber)
         {
            Console.WriteLine("Число больше заданного");
            return false;
         }
         else
         {
            return false;
         }
      }
      #endregion


   }


}

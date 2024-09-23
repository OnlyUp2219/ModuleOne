namespace BinarySearch
{
   internal class GuessNumber
   {
      static void Main(string[] args)
      {
         GuessNumber search = new GuessNumber();
         search.Start();
      }

      bool isRightAnswer = false;

      private void Start()
      {

         while (!isRightAnswer)
         {
            int number;
            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out number);
            isRightAnswer = GuessNumber(number, 99);
         }
            Console.WriteLine("Конец приложения!");
      }

      private int RandomNumber()
      {
         Random random = new Random();
         int number = random.Next(1, 100);
         return number;
      }

      private bool GuessNumber(int number, int randomNumber)
      {
         if (number == randomNumber)
         {
            Console.WriteLine($"Вы угадали чиcло это {randomNumber}");
            return true;
         }
         else if (number >= randomNumber)
         {
            Console.WriteLine($"Число больше заданного");
            return false;
         }
         else if (number <= randomNumber)
         {
            Console.WriteLine("Число меньше заданного");
            return false;
         }
         else
         {
            return false;
         }
      }
   }


}

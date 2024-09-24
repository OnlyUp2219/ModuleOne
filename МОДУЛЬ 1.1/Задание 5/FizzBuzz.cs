namespace FizzBuzz
{
   internal class FizzBuzz
   {
      static void Main(string[] args)
      {
         FizzBuzz fizzBuzz = new FizzBuzz();
         fizzBuzz.Start();
      }

      #region Точка начала
      private void Start()
      {
         for (int i = 1; i <= 100; i++)
         {
            Console.WriteLine(Condition(i));
         }
      }
      #endregion

      #region Условия вывода
      private string Condition(int number)
      {
         if (number % 3 == 0 && number % 5 == 0)
         {
            return "FizzBuzz";
         }
         else if (number % 5 == 0)
         {
            return "Buzz";
         }
         else if (number % 3 == 0)
         {
            return "Fizz";
         }
         else
         {
            return number.ToString();
         }
      }
      #endregion
   }
}

using System;

namespace Substrings
{
   internal class Substrings
   {
      static void Main(string[] args)
      {
         Substrings substrings = new Substrings();
         substrings.Start();
      }

      #region Точка входа в приложение
      private void Start()
      {
         Console.WriteLine("Введите строку:");
         string? strMain = Console.ReadLine();
         Console.WriteLine("Введите подстроку:");
         string? strSub = Console.ReadLine();

         bool result = isSubstrings(strMain, strSub);
         Console.WriteLine(result
             ? $"\"{strSub}\" является подстрокой \"{strMain}\"."
             : $"\"{strSub}\" не является подстрокой \"{strMain}\".");
      }
      #endregion

      #region Проверка на подстроку
      private bool isSubstrings(string strMain, string strSub)
      {
         return strMain.Contains(strSub);
      }
      #endregion
   }
}

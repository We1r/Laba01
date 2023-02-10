using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************
 * Автор: Козлов Егор             * 
 * Тема: Базовые понятия языка С# *
 **********************************/

namespace Laba01 {
  internal class Laba01 {
    static void Main(string[] args) {
      Console.WriteLine("Введите номер задания :");
      int task = int.Parse(Console.ReadLine());

      if (task == 1) {
        Console.WriteLine("Введите действительное число a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите степень n:");
        int n = int.Parse(Console.ReadLine());

        double result = 1;

        for (int i = 0; i < n; ++i) {
          result *= a;
        }

        Console.WriteLine("a^n = " + result);
        Console.ReadKey();
      }

      if (task == 2) {
        Console.WriteLine("Введите число состоящее из трёх или более цифр :");
        int number = int.Parse(Console.ReadLine());

        if (number >= 100) {
          int digitCount = (int)Math.Log10(number) + 1;

          string s = number.ToString();
          string result = s[s.Length - digitCount].ToString();
          for (int i = digitCount; i >= 1; --i) {
            if (i != (digitCount - 1) && i != digitCount) {
              result += s[s.Length - i].ToString();
            }
          }
          result += s[s.Length - (digitCount - 1)].ToString();

          Console.WriteLine(result);
          Console.ReadKey();
        } else {
          Console.WriteLine("В этом числе менее трёх цифр");
          Console.ReadKey();
        }
      }
    }
  }
}

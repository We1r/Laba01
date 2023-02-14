using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1 {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите номер задания :");
      int task = int.Parse(Console.ReadLine());

      if (task == 1) {
        Console.WriteLine("Введите действительное число a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите степень n:");
        int n = int.Parse(Console.ReadLine());

        double result = 1;

        for (int numberCount = 0; numberCount < n; ++numberCount) {
          result *= a;
        }

        Console.WriteLine("a^n = " + result);
        Console.ReadKey();
      } else if (task == 2) {
        Console.WriteLine("Введите число состоящее из трёх или более цифр :");
        int number = int.Parse(Console.ReadLine());

        if (number >= 100) {
          int digitCount = (int)Math.Log10(number) + 1;

          string str = number.ToString();
          string result = str[str.Length - digitCount].ToString();
          for (int digitPosition = digitCount; digitPosition >= 1; --digitPosition) {
            if (digitPosition != (digitCount - 1) && digitPosition != digitCount) {
              result += str[str.Length - digitPosition].ToString();
            }
          }
          result += str[str.Length - (digitCount - 1)].ToString();

          Console.WriteLine(result);
          Console.ReadKey();
        } else {
          Console.WriteLine("В этом числе менее трёх цифр");
          Console.ReadKey();
        }
      } else {
        Console.WriteLine("Такого задания нет");
        Console.ReadKey();
      }
    }
  }
}

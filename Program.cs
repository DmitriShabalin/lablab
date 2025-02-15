using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
  internal class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
         Console.Write("\nВыберите задане: \n1) Задание 1, \n2) Задание 2 \n");
         int task = Convert.ToInt32(Console.ReadLine());

         switch (task)
         {
           case 1:
             Console.Write("\nВведите число а: ");
             double a = Convert.ToDouble(Console.ReadLine());
             Console.Write("Введите степень в которую нужно возвести число (n): ");
             double n = Convert.ToDouble(Console.ReadLine());
             double b = 1.0;

             for (int i = 0; i < n; i++)
             {
               b = b * a;
             }
             Console.Write("\nРезультат: " + b + "\n");
             break;

            case 2:
              Console.Write("\nЧисло до изменения: ");
              string x = Console.ReadLine();
              char secondNumber = x[1];

              Console.WriteLine("\nЧисло после изменения: " + x);

              x = x.Remove(1, 1);
              x += secondNumber;

              Console.Write("Результат: " + x + "\n");
              break;
            }
        }
    }
        
    }
}

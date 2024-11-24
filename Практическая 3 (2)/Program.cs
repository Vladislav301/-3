using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практическая_3__1_;

namespace Практическая_3__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gru func = new gru();

            func.HelloWorld("Дмитрий");
            func.Surname("Павлов");
            Console.Write("Введите возраст: ");
            if (int.TryParse(Console.ReadLine(), out int age))
              {
            DateTime? birthDate = gru.GetApproximateBirthDate(age);
            if (birthDate.HasValue)
              {
            Console.WriteLine($"Приблизительная дата рождения: {birthDate.Value.ToShortDateString()}");
              }
            else
              {
            Console.WriteLine("Некорректный возраст.");
              }
              }
             else
              {
            Console.WriteLine("Неверный формат ввода.");
              }
            Console.ReadLine();
        }
        
    }
    
}

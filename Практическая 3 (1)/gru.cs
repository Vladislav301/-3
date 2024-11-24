using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Практическая_3__1_
{
    public class gru
    {
        public void HelloWorld(string name)
        {
            Console.WriteLine($"Привет, {name}");
        }

        public void Surname(string surname)
        {
            Console.WriteLine($"{surname}");
        }

        public static DateTime? GetApproximateBirthDate(int age)
        {
            if (age <= 0)
            {
                return null;
            }
            DateTime today = DateTime.Today;
            return today.AddYears(-age);
        }



    }
    
    
}
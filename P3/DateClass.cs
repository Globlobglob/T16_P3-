﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    internal class DateClass
    {
       
        DateTime data;
        //public DateTime Data { get => data; set => data = value; }
        public DateClass() { }

        public DateClass(int day,int month,int year)
        {
            data = new DateTime(day, month, year);
        }

        public void NextDay()
        {
            Console.WriteLine($"Предыдущий день {data.AddDays(-1).ToString("d")}");
        }
        public void PastDay()
        {
           Console.WriteLine($"Последующий день {data.AddDays(+1).ToString("d")}");
        }

        public void DaysCalc()
        {
            Console.WriteLine($"До конца месяца {DateTime.DaysInMonth(data.Year, data.Month) - data.Day}");
        }

       
      



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar();

            // Додавання дат
            calendar.Add(new Date(1, 1, 2022));
            calendar.Add(new Date(2, 1, 2022));
            calendar.Add(new Date(3, 1, 2022));
            calendar.Add(new Date(1, 2, 2022));
            calendar.Add(new Date(14, 2, 2022));
            calendar.Add(new Date(1, 3, 2022));

            // Виведення дат для певного місяця та року
            List<Date> january2022Dates = calendar.GetDatesForMonth(1, 2022);
            Console.WriteLine("January 2022 dates:");
            foreach (Date date in january2022Dates)
            {
                Console.WriteLine(date);
            }

            // Видалення дати
            calendar.Remove(new Date(1, 3, 2022));

            // Виведення дат після видалення
            List<Date> march2022Dates = calendar.GetDatesForMonth(3, 2022);
            Console.WriteLine("March 2022 dates:");
            foreach (Date date in march2022Dates)
            {
                Console.WriteLine(date);
            }
        }
    }
}

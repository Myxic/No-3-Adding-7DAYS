using System;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;


namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateby1wk = Dates();
            Console.WriteLine("");
            Console.WriteLine(dateby1wk);
        }

        public static string Dates()
        {
            Console.WriteLine("Input a date in this format: dd/mm/yyyy");

            var date = Console.ReadLine();

            DateOnly dateValue = DateOnly.Parse(date);
            dateValue = dateValue.AddDays(7);
            Console.WriteLine(dateValue.Day + "/" + dateValue.Month + "/" + dateValue.Year );

            return dateValue.ToString();
        }

    }
}
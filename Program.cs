using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФОРМУЛА_ДИСКРИМИНАНТА
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную b:");
            double b = Convert.ToInt16(Console.ReadLine());
            b = Math.Pow(b, 2);
            Console.Write("Введите переменную a:");
            double a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите переменную c:");
            double с = Convert.ToInt16(Console.ReadLine());

            double D = b - 4 * a * с;
            Console.WriteLine("Ваш дискриминант:" + D);
            Console.ReadLine();

        }
    }
}

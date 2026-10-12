using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program42
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Целое число: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                double root = Math.Sqrt(n);
                int intRoot = (int)root;
                bool isPerfectSquare = (intRoot * intRoot == n);
                Console.WriteLine(isPerfectSquare ? "Полный квадрат" : "Не полный квадрат");
            }
            else
            {
                Console.WriteLine("Ошибка: введите неотрицательное целое число.");
            }
        }
    }
}
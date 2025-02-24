using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{/// <summary>
/// 4) Заполнить одномерный массив случайным образом и вывести на экран с использованием цикла foreach.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] mas = new int[5];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next();
            }
            Console.Write("mas:");
            foreach (int item in mas)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}

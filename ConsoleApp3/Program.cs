using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
/// 1) Выполнить инициализацию одномерного массива с использованием конструктора без указания значений элементов и вывести на экран.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[5];
            Console.Write("mas:");
            foreach (int item in mas)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
    }
}

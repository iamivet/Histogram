using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HistogramMVC.View
{
    public class Display
    {
        public int[] Numbers { get; set; }

        public  int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }
        public int P4 { get; set; }
        public int P5 { get; set; }

        public void Input()
        {
            //    Console.WriteLine("Въведи редица от числа:");
            //    this.Numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            this.Numbers = numbers;
        }

        public void Output()
        {
            Console.WriteLine($"Числата , които са под 200 са:{(double)this.P1 / this.Numbers.Length * 100:f2}%");
            Console.WriteLine($"Числата , които са от 200 до 399 са:{(double)this.P2 / this.Numbers.Length * 100:f2}%");
            Console.WriteLine($"Числата , които са от 400 до 599 са:{(double)this.P3 / this.Numbers.Length * 100:f2}%");
            Console.WriteLine($"Числата , които са от 600 до 799 са:{(double)this.P4 / this.Numbers.Length * 100:f2}%");
            Console.WriteLine($"Числата , които са от 800 нагоре са:{(double)this.P5 / this.Numbers.Length * 100:f2}%");
        }
    }
}

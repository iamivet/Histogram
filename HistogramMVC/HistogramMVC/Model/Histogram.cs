using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistogramMVC.Model
{
    public class Histogram
    {
        public int[] Numbers { get; }

        public int P1 { get; private set; }
        public int P2 { get; private set; }
        public int P3 { get; private set; }
        public int P4 { get; private set; }
        public int P5 { get; private set; }

        public Histogram(int[] numbers)
        {
            this.Numbers = numbers;
        }
        public void CalculateCount()
        {
            foreach (int number in this.Numbers)
            {
                if (number < 200)
                {
                    this.P1++;
                }
                else if (number < 400)
                {
                    this.P2++;
                }
                else if (number < 600)
                {
                    this.P3++;
                }
                else if (number < 800)
                {
                    this.P4++;
                }
                else
                {
                    this.P5++;
                }
            }
        }
    }
}

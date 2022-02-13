using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.ByTwos();
            arith.Reset();
            arith.Reset();
            arith.Reset();
            Console.WriteLine();

            GeomProgression geom = new GeomProgression();
            geom.ByTwos();
            geom.Reset();
            geom.Reset();
            geom.Reset();

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void SetStart
            (int x);
        int GetNext();
        void Reset();

    }
    class ArithProgression : ISeries
    {
        int start;
        int val;
        public void ByTwos()
        {
            start = Convert.ToInt32(Console.ReadLine());
            val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Арифметическая прогрессия");
            Console.WriteLine("Начальное значение {0}", start);
            Console.WriteLine("Шаг {0}", val);
            Console.WriteLine();
        }
        public int GetNext()
        {
            return start;
        }
        public void Reset()
        {
            start = val + start;
            Console.WriteLine("Следующее значение {0}", start);
        }
        public void SetStart(int x)
        {
            val = x;
            start = val;
        }

    }
    class GeomProgression : ISeries
    {
        int start;
        int val;
        public void ByTwos()
        {
            start = Convert.ToInt32(Console.ReadLine());
            val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Геометричесая прогрессия");
            Console.WriteLine("Начальное значение {0}", start);
            Console.WriteLine("Шаг {0}", val);
            Console.WriteLine();
        }
        public int GetNext()
        {
            return start;
        }

        public void Reset()
        {
            start = start * val;
            if (start == 0 || val == 0)
            {
                Console.WriteLine("Некорректное значение чисел в последовательности");
            }
            else
            {
                Console.WriteLine("Следующее значение {0}", start);
            }
        }
        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
}

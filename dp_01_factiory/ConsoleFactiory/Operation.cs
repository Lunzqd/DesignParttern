using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactiory
{
    public abstract class Operation
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;

            switch (operate)
            {
                case "+": result = numberA + numberB; break;
                case "-": result = numberA - numberB; break;
                case "*": result = numberA * numberB; break;
                case "/": result = numberA / numberB; break;
                default: Console.WriteLine("无效运算符"); break;
            }
            return result;
        }

        //=============下面是工厂参数

        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA { get => _numberA; set => _numberA = value; }
        public double NumberB { get => _numberB; set => _numberB = value; }

        //虚方法
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}

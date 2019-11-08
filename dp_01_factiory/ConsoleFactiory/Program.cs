using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactiory
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestA(); 
            //TestB();
            //TestC();
            TestD();
        }

        /// <summary>
        /// 一般方法
        /// </summary>
        public static void TestA()
        {
            Console.WriteLine("请输入数字");
            string strNumberA = Console.ReadLine();
            Console.WriteLine("请输入运算符+,-,*,/");
            string strOperate = Console.ReadLine();
            Console.WriteLine("请输入数字");
            string strNumberB = Console.ReadLine();

            double result = 0;
            if (strOperate == "+")
            {
                result = Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB);
            }
            else if (strOperate == "-")
            {
                result = Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB);
            }
            else if (strOperate == "*")
            {
                result = Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB);
            }
            else if (strOperate == "/")
            {
                result = Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB);
            }
            else
            {
                Console.WriteLine("无效运算符");
            }
            Console.WriteLine("结果:" + result.ToString());
            Console.ReadLine();

            Console.WriteLine("========================");
            TestA();
        }
        /// <summary>
        /// 优化一下
        /// </summary>
        public static void TestB()
        {
            Console.WriteLine("请输入数字");
            string strNumberA = Console.ReadLine();
            Console.WriteLine("请输入运算符+,-,*,/");
            string strOperate = Console.ReadLine();
            Console.WriteLine("请输入数字");
            string strNumberB = Console.ReadLine();

            double result = 0;
            switch (strOperate)
            {
                case "+": result = Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB); break;
                case "-": result = Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB); break;
                case "*": result = Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB); break;
                case "/":
                    if (Convert.ToDouble(strNumberB) != 0)
                        result = Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB);
                    else
                        Console.WriteLine("被除数不能为0");
                    break;
                default: Console.WriteLine("无效运算符"); break;
            }
            Console.WriteLine("结果:" + result.ToString());
            Console.ReadLine();

            Console.WriteLine("========================");
            TestB();
        }
        /// <summary>
        /// 封装一下
        /// </summary>
        public static void TestC()
        {
            Console.WriteLine("请输入数字");
            string strNumberA = Console.ReadLine();
            Console.WriteLine("请输入运算符+,-,*,/");
            string strOperate = Console.ReadLine();
            Console.WriteLine("请输入数字");
            string strNumberB = Console.ReadLine();

            double result = 0;
            result = Operation.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate);

            Console.WriteLine("结果:" + result.ToString());
            Console.ReadLine();

            Console.WriteLine("========================");
            TestC();
        }

        /// <summary>
        /// 继承,多态 ; 工厂模式 
        /// </summary>
        public static void TestD()
        {

            Console.WriteLine("请输入数字");
            string strNumberA = Console.ReadLine();
            Console.WriteLine("请输入运算符+,-,*,/");
            string strOperate = Console.ReadLine();
            Console.WriteLine("请输入数字");
            string strNumberB = Console.ReadLine();


            Operation oper = null;
            oper = OperationFactory.createOperate(strOperate);
            oper.NumberA = Convert.ToDouble(strNumberA);
            oper.NumberB = Convert.ToDouble(strNumberB);

            double result = oper.GetResult();

            Console.WriteLine("结果:" + result.ToString());
            Console.ReadLine();

            Console.WriteLine("========================");
            TestD();
        }




    }
}

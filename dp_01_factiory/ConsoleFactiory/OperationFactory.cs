using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactiory
{
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;

            switch (operate)
            {
                case "+": oper = new OperateAdd(); break;
                case "-": oper = new OperateSub(); break;
                case "*": oper = new OperateMul(); break;
                case "/": oper = new OperateDiv(); break;
            }
            return oper;

        }

    }
}

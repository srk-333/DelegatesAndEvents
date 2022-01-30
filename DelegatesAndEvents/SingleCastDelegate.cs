using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class SingleCastDelegate
    {
        delegate int MyDelegate(int x, int y);
        public static void ImplementSingleDelegate()
        {
            MyDelegate del = new MyDelegate(Addition);
            Console.WriteLine("Addition = {0}",del(25,30));
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{   
    /* Multicast Delegates
     * In this Delegate, we can invoke more than one method with same signature
     * use += operator to implemet Multicast Delegate
     * += operator is used to assign Multiple Methods to delegate object.
     */
    public class MultiCastDelegate
    {
        delegate void DelOP(int x, int y);
        public static void ImplementMultiDelegate()
        {
            //Delegates instantiation
            DelOP del = Operation.Add;
            del += Operation.Multiply;
            del(5, 5);
            del(8, 5);
            Console.ReadLine();
        }
        public class Operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition is ={0}",a+b);
            }
            public static void Multiply(int a, int b)
            {
                Console.WriteLine("Multiply is ={0}",a*b);
            }
        }
    }
}

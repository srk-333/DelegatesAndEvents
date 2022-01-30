using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void DelEventHandler();
    class Program
    {
        public static event DelEventHandler add;
        static void Main(string[] args)
        {
            add += new DelEventHandler(India);
            add += new DelEventHandler(Bhutan);
            add += new DelEventHandler(Nepal);

            add.Invoke();
            Console.WriteLine("<----Event Handling---->");
            EventHandling.ImplementEvent();
            Console.ReadLine();
        }
        private static void India()
        {
            Console.WriteLine("India");
        }
        private static void Bhutan()
        {
            Console.WriteLine("Bhutan");
        }
        private static void Nepal()
        {
            Console.WriteLine("Nepal");
        }
    }
}

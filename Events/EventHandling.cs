using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void EventHandler(string x);
    class EventHandling
    {
        public class Opearation
        {
            public event EventHandler xyz;
            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImplementEvent()
        {
            Opearation op = new Opearation();
            op.Action("Method Calling");
            Console.WriteLine();
            op.xyz += new EventHandler(CatchEvent);
            op.Action("Event Called!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Program
    {                   
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Delegates And Events Program Implementation");
            Console.WriteLine("Single Cast Delegate Example");
            SingleCastDelegate.ImplementSingleDelegate();
            Console.WriteLine("Multi Cast Delegates Example");
            MultiCastDelegate.ImplementMultiDelegate();
            Console.ReadLine();
        }
    }  
}
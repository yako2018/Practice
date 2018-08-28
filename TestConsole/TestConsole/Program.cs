using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program : myBase
    {
        static void Main(string[] args)
        {
            new Program().YouMustImplement();
            new Program().YouCanOverride();
            Console.ReadLine();
        }

        public override void YouMustImplement()
        {
            Console.WriteLine("override YouMustImplement");
        }

        //public override void YouCanOverride()
        //{
        //    Console.WriteLine("override YouCanOverride");
        //}
    }

    public abstract class myBase
    {
        //If you derive from this class you must implement this method. notice we have no method body here either
        public abstract void YouMustImplement();

        //If you derive from this class you can change the behavior but are not required to
        public virtual void YouCanOverride()
        {
            Console.WriteLine("virtual YouMustImplement");
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        interface IA
        {
            void doit();
        }
        interface IB
        {
            void doit();
        }
        class A : IA, IB
        {
            public virtual void doit()
            {
                Console.WriteLine("A");
            }
        }
        class B : A
        {
            public new void doit()
            {
                Console.WriteLine("B");
            }
        }

        static void Main(string[] args)
        {
            A a = new B();
            try
            {
                a.doit();
            }
            catch (IOException e)
            {
            }
            catch (Exception e)
            {
            }
            Console.ReadLine();
        }
    }
}

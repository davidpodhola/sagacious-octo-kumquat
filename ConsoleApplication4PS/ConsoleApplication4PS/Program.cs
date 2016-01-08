using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;

namespace ConsoleApplication4PS
{
    class Program
    {
        [Log]
        public void DoWork()
        {
            System.Console.WriteLine("Hello world");
        }

        static void Main(string[] args)
        {
            var program = new Program();
            program.DoWork();
            System.Console.WriteLine("Press ENTER to close");
            Console.ReadLine();
        }
    }
}

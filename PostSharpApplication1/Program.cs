using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;

namespace PostSharpApplication1
{
    class Program
    {
        [Log]
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}

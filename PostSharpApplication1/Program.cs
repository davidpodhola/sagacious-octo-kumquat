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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static Program()
        {
            log4net.Config.BasicConfigurator.Configure();
        }


        [Log]
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}

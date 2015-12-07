using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;
using PostSharp.Patterns.Threading;

namespace PostSharpApplication1
{
    [Actor]
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static Program()
        {
            log4net.Config.BasicConfigurator.Configure();
        }

        float sum;
        int count;

        public void AddSample(float n)
        {
            this.count++;
            this.sum += n;
        }

        public async Task<float> GetAverage()
        {
            return this.sum / this.count;
        }

        [Log]
        static void Main(string[] args)
        {
            var program = new Program();
            Console.ReadLine();
        }
    }
}

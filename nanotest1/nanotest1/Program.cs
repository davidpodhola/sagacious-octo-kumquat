using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExt;

namespace nanotest1
{
    class Program
    {
        public static decimal getSD() {
          var data = new List<Tuple<string, double>> { Tuple.Create("A", 1.0), Tuple.Create("B", 2.1), Tuple.Create("C", 1.5) };
            return (decimal) Math.Round( data.Select(x => x.Item2).StandardDeviation(), 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(getSD());
        }
    }
}

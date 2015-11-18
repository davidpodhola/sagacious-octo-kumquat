using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTest1
{
    class Program
    {
        //[DllImport("kernel32")]

        static void Main(string[] args)
        {
            /*
            List<KeyValuePair<string, string>> myList = null;
            myList.Sort( p => p )

            string s = null;
            s.IndexOf()

            Thread t = null;
            t.Join();
            IEnumerable<string> b = null;
            string.Join();

            Assembly

            string s = "xyz";
            */
            var c = new Class1();
            c.Save();
            c.Save();
            c.Save();
            c.Save();
            c.Save();

            var numbers = new List<int> { 1,2,3,4 };
            numbers.Add(5);
            var lessThen = numbers.Where(n => n < 10);
            numbers.Clear();

            Console.WriteLine(lessThen.Count());
            Console.ReadLine();
        }
    }
}

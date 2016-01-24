using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            for (char i = (char)0; i < 65536; i++)
            {
                Console.WriteLine(i);
            }
            */
            //Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("┌─┐");
            Console.WriteLine("│1│");
            Console.WriteLine("└─┘");
            string s = "╔";
            Console.WriteLine(s);
        }
    }
}

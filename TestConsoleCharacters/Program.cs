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
            char c = '┐';
            Console.WriteLine((int)c);
            Console.WriteLine("------------------------------------");
            for (char i = (char)9480; i < 9490; i++)
            {
                Console.WriteLine((int)i + ":" + i);
            }
            Console.WriteLine("------------------------------------");
            //Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("┌─┐");
            Console.WriteLine("│1│");
            Console.WriteLine("└─┘");
            string s = "╔";
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

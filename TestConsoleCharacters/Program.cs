using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleCharacters
{
    public class Program
    {
        public static void Test ()
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
            Console.WriteLine("------------------------------------");
            // https://en.wikipedia.org/wiki/Box-drawing_character
            Console.WriteLine("╠╡"); // Table 1
            Console.WriteLine("------------------------------------");
            Console.WriteLine("╨╫"); // Table 2
            Console.WriteLine("------------------------------------");
            Console.WriteLine("╚╬"); // Table 3
            Console.ReadLine();
        }

        public static void Main(string[] args) {
            Console.WriteLine(Console.Out.Encoding.ToString());
            Console.WriteLine(Console.Out.Encoding.CodePage);
            Console.WriteLine(Console.Out.Encoding.EncodingName);
            Console.WriteLine(Console.Out.Encoding.WebName);
            Console.WriteLine("------------------------------------");
            for (char i = (char)33; i < 255; i++)
            {
                Console.Write((int)i + ":" + i + " ");
                if (i % 10 == 0) Console.WriteLine();
            }

            Console.SetCursorPosition(5, 5);
            Console.Write("AAA");
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
            Test();
        }
    }
}


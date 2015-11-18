using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest1
{
    class Class1
    {
        private int x;

        public void Save()
        {
            x++;
        }

        internal int y()
        {
            return x;
        }
    }
}

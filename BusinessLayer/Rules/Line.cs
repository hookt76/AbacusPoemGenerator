using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Rules
{
     public static class Line
    {
        private static StringBuilder _line = new StringBuilder();

        public static StringBuilder Get()
        {
            return _line;
        }

        public static void Set(string value)
        {
            _line.Append( value);
        }

        public static void Clear()
        {
            _line.Clear();
        }

    }
}

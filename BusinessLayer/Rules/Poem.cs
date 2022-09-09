using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Rules
{
    public static class Poem
    {
        private static List<string> _poem = new List<string>();

        public static List<string> Get()
        {
            if (_poem == null)
            {
                _poem = new List<string>();
            }
            return _poem;
        }

        public static void Set(string value)
        {
            if (_poem == null)
            {
                _poem = new List<string>();
            }
            _poem.Add(value);
        }

        public static string GetData(int index)
        {
            if (_poem == null)
            {
                _poem = new List<string>();
            }
            return _poem[index];
        }
    }
}

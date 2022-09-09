using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Rules
{
    public static class Verb
    {
        private static List<string> _verbs = new List<string>();

        public static List<string> Get()
        {
            if (_verbs == null)
            {
                _verbs = new List<string>();
            }
            return _verbs;
        }

        public static void Set(string value)
        {
            if (_verbs == null)
            {
                _verbs = new List<string>();
            }
            _verbs.Add(value);
        }

        public static string GetData(int index)
        {
            if (_verbs == null)
            {
                _verbs = new List<string>();
            }
            return _verbs[index];
        }

        public static string GetExtendedData()
        {
            return GetRandomExtendedData(2);
        }

        private static string GetRandomExtendedData(int maxNumber)
        {
            var rand = Helper.RandomNumberGenerator.GetRandomNumber(maxNumber);

            if (rand == 0)
            {
                // get a pronoun
                var nounRand = Helper.RandomNumberGenerator.GetRandomNumber(ProNoun.Get().Count());
                return Noun.Get()[nounRand];
            }
            else
            {
                // get a preposition
                var adjRand = Helper.RandomNumberGenerator.GetRandomNumber(Preposition.Get().Count());
                return Noun.Get()[adjRand];
            }
        }
    }
}

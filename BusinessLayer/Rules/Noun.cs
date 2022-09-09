using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Rules
{
    public static class Noun
    {

        private static List<string> _nouns = new List<string>();

        public static List<string> Get()
        {
            if (_nouns == null)
            {
                _nouns = new List<string>();
            }
            return _nouns;
        }

        public static void Set(string value)
        {
            if (_nouns == null)
            {
                _nouns = new List<string>();
            }
            _nouns.Add(value);
        }

        public static string GetData(int index)
        {
            if (_nouns == null)
            {
                _nouns = new List<string>();
            }
            return _nouns[index];
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
                // get a noun
                var nounRand = Helper.RandomNumberGenerator.GetRandomNumber(Verb.Get().Count());
                return Noun.Get()[nounRand];
            }
            else
            {
                // get a adjective
                var adjRand = Helper.RandomNumberGenerator.GetRandomNumber(Preposition.Get().Count());
                return Noun.Get()[adjRand];
            }
        }
    }
}

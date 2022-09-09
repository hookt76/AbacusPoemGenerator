using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Rules
{
    public static class ProNoun
    {

        private static List<string> _proNouns = new List<string>();

        public static List<string> Get ()
        {
            if (_proNouns == null)
            {
                _proNouns = new List<string>();
            }
            return _proNouns;
        }

        public static void Set(string value)
        {
            if (_proNouns == null)
            {
                _proNouns = new List<string>();
            }
            _proNouns.Add(value);
        }

        public static string GetData(int index)
        {
            if (_proNouns == null)
            {
                _proNouns = new List<string>();
            }
            return _proNouns[index];
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
                var nounRand = Helper.RandomNumberGenerator.GetRandomNumber(Noun.Get().Count());
                return Noun.Get()[nounRand];
            }
            else
            {
                // get a adjective
                var adjRand = Helper.RandomNumberGenerator.GetRandomNumber(Adjective.Get().Count());
                return Noun.Get()[adjRand];
            }
        }

    }
}

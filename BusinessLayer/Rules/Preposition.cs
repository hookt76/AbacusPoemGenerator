using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Rules
{
    public static class Preposition
    {

        private static List<string> _prepositions = new List<string>();

        public static List<string> Get()
        {
            if (_prepositions == null)
            {
                _prepositions = new List<string>();
            }
            return _prepositions;
        }

        public static void Set(string value)
        {
            if (_prepositions == null)
            {
                _prepositions = new List<string>();
            }
            _prepositions.Add(value);
        }

        public static string GetData(int index)
        {
            if (_prepositions == null)
            {
                _prepositions = new List<string>();
            }
            return _prepositions[index];
        }

        public static string GetExtendedData()
        {
            return GetRandomExtendedData(3);
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
            if(rand == 1)
            {
                // get a pronoun
                var adjRand = Helper.RandomNumberGenerator.GetRandomNumber(ProNoun.Get().Count());
                return Noun.Get()[adjRand];
            }
            else
            {
                // get a adj
                var adjRand = Helper.RandomNumberGenerator.GetRandomNumber(Adjective.Get().Count());
                return Noun.Get()[adjRand];
            }
        }
    }
}

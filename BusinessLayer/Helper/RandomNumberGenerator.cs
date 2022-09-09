using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Helper
{
    public static class RandomNumberGenerator
    {
        public static int GetRandomNumber(int MaxNumber)
        {

            Random rnd = new Random();
            int result = rnd.Next(MaxNumber - 1);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PoemBuilder
    {
        public List<string> GetPoem(string path, char[] seperator)
        {
            Helper.RuleLoader loader = new Helper.RuleLoader();
            loader.LoadData(path, seperator);
            return SendPoem();
        }

        private List<string> SendPoem()
        {
            Rules.Poem.Set(null);
            int rand = 0;
            int count = 0;
            bool isRunning = true;

            while (count < 5)
                {
                
                rand = Helper.RandomNumberGenerator.GetRandomNumber(5);

                switch (rand)
                {
                    case 0:
                        {
                            int adjRand = Helper.RandomNumberGenerator.GetRandomNumber(Rules.Adjective.Get().Count);

                            Rules.Line.Set(Rules.Adjective.GetData(adjRand) + " ");
                            Rules.Line.Set(Rules.Adjective.GetExtendedData() + " ");
                            Rules.Line.Set(Environment.NewLine);
                            Rules.Poem.Set(Rules.Line.Get().ToString());
                            Rules.Line.Clear();
                            count++;

                        }
                        break;
                    case 1:
                        {
                            int nounRand = Helper.RandomNumberGenerator.GetRandomNumber(Rules.Noun.Get().Count);

                            Rules.Line.Set(Rules.Noun.GetData(nounRand) + " ");
                            Rules.Line.Set(Rules.Noun.GetExtendedData() + " ");
                            Rules.Line.Set(Environment.NewLine);
                            Rules.Poem.Set(Rules.Line.Get().ToString());
                            Rules.Line.Clear();
                            count++;

                        }
                        break;
                    case 2:
                        {
                            int pronounRand = Helper.RandomNumberGenerator.GetRandomNumber(Rules.ProNoun.Get().Count);
                            Rules.Line.Set(Rules.ProNoun.GetData(pronounRand) + " ");
                            Rules.Line.Set(Rules.ProNoun.GetExtendedData() + " ");
                        }
                        break;
                    case 3:
                        {
                            int verbRand = Helper.RandomNumberGenerator.GetRandomNumber(Rules.Verb.Get().Count);

                            Rules.Line.Set(Rules.Verb.GetData(verbRand) + " ");
                            Rules.Line.Set(Rules.Verb.GetExtendedData() + " ");
                            Rules.Line.Set(Environment.NewLine);
                            Rules.Poem.Set(Rules.Line.Get().ToString());
                            Rules.Line.Clear();
                            count++;
                        }
                        break;
                    case 4:
                        {
                            int prepRand = Helper.RandomNumberGenerator.GetRandomNumber(Rules.Preposition.Get().Count);
                            Rules.Line.Set(Rules.Preposition.GetData(prepRand) + " ");
                            Rules.Line.Set(Rules.Preposition.GetExtendedData() + " ");
                        }
                        break;
                    default:
                        break;
                }

                Thread.Sleep(2000);
            } ;

            return Rules.Poem.Get();
        }

    }
}

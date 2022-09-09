using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer.Helper
{
    public class RuleLoader
    {

        public void LoadData(string path, char[] seperator)
        {
            var words = GetFile(path, seperator);

            foreach (var item in words)
            {
                switch (item)
                {
                    case nameof(RulesEnum.Adjective.black):
                    case nameof(RulesEnum.Adjective.bright):
                    case nameof(RulesEnum.Adjective.clear):
                    case nameof(RulesEnum.Adjective.dark):
                    case nameof(RulesEnum.Adjective.muddy):
                    case nameof(RulesEnum.Adjective.murky):
                    case nameof(RulesEnum.Adjective.white):

                        {
                            BusinessLayer.Rules.Adjective.Set(item);
                        }
                        break;
                    case nameof(RulesEnum.Noun.brother):
                    case nameof(RulesEnum.Noun.sun):
                    case nameof(RulesEnum.Noun.moon):
                    case nameof(RulesEnum.Noun.thunder):
                    case nameof(RulesEnum.Noun.fire):
                    case nameof(RulesEnum.Noun.time):
                    case nameof(RulesEnum.Noun.wind):
                    case nameof(RulesEnum.Noun.sea):
                    case nameof(RulesEnum.Noun.river):
                    case nameof(RulesEnum.Noun.flavor):
                    case nameof(RulesEnum.Noun.wave):
                    case nameof(RulesEnum.Noun.willow):
                    case nameof(RulesEnum.Noun.rain):
                    case nameof(RulesEnum.Noun.tree):
                    case nameof(RulesEnum.Noun.flower):
                    case nameof(RulesEnum.Noun.field):
                    case nameof(RulesEnum.Noun.meadow):
                    case nameof(RulesEnum.Noun.pasture):
                    case nameof(RulesEnum.Noun.harvest):
                    case nameof(RulesEnum.Noun.water):
                    case nameof(RulesEnum.Noun.father):
                    case nameof(RulesEnum.Noun.mother):
                    case nameof(RulesEnum.Noun.sister):
                        {
                            BusinessLayer.Rules.Noun.Set(item);
                        }
                        break;
                    case nameof(RulesEnum.Preposition.above):
                    case nameof(RulesEnum.Preposition.across):
                    case nameof(RulesEnum.Preposition.against):
                    case nameof(RulesEnum.Preposition.along):
                    case nameof(RulesEnum.Preposition.among):
                    case nameof(RulesEnum.Preposition.around):
                    case nameof(RulesEnum.Preposition.before):
                    case nameof(RulesEnum.Preposition.behind):
                    case nameof(RulesEnum.Preposition.beneath):
                    case nameof(RulesEnum.Preposition.beside):
                    case nameof(RulesEnum.Preposition.between):
                    case nameof(RulesEnum.Preposition.beyond):
                    case nameof(RulesEnum.Preposition.during):
                    case nameof(RulesEnum.Preposition.inside):
                    case nameof(RulesEnum.Preposition.onto):
                    case nameof(RulesEnum.Preposition.outside):
                    case nameof(RulesEnum.Preposition.under):
                    case nameof(RulesEnum.Preposition.underneath):
                    case nameof(RulesEnum.Preposition.upon):
                    case nameof(RulesEnum.Preposition.with):
                    case nameof(RulesEnum.Preposition.without):
                    case nameof(RulesEnum.Preposition.through):
                        {
                            BusinessLayer.Rules.Preposition.Set(item);
                        }
                        break;
                    case nameof(RulesEnum.Pronoun.her):
                    case nameof(RulesEnum.Pronoun.his):
                    case nameof(RulesEnum.Pronoun.my):
                    case nameof(RulesEnum.Pronoun.your):
                        {
                            BusinessLayer.Rules.ProNoun.Set(item);
                        }
                        break;
                    case nameof(RulesEnum.Verb.ascends):
                    case nameof(RulesEnum.Verb.climbs):
                    case nameof(RulesEnum.Verb.crawls):
                    case nameof(RulesEnum.Verb.descends):
                    case nameof(RulesEnum.Verb.flies):
                    case nameof(RulesEnum.Verb.flows):
                    case nameof(RulesEnum.Verb.runs):
                    case nameof(RulesEnum.Verb.sinks):
                    case nameof(RulesEnum.Verb.stands):
                    case nameof(RulesEnum.Verb.transcends):
                    case nameof(RulesEnum.Verb.walks):
                        {
                            BusinessLayer.Rules.Verb.Set(item);
                        }
                        break;
                    case nameof(RulesEnum.KeyWord.end):
                        {
                            BusinessLayer.Rules.Verb.Set(item);
                            BusinessLayer.Rules.Noun.Set(item);
                            BusinessLayer.Rules.Adjective.Set(item);
                        }
                        break;
                    case nameof(RulesEnum.KeyWord.linebreak):
                        {
                            BusinessLayer.Rules.Line.Set(item);
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        private List<string> GetFile(string path, char[] seperator)
        {

            ReadIO reader = new ReadIO();
            string data = reader.GetFile(path);
            List<string> results = new List<string>();
            results.AddRange(data.Split(seperator));
            return results;
        }
    }


}

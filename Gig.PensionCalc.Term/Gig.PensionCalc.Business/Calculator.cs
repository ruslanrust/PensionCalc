using Gig.PensionCalc.Business.Rules;
using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Business
{
    public class Calculator
    {
        private IEnumerable<IPensionRule> Rules { get; set; }

        public Calculator()
        {
            Rules = new List<IPensionRule>()
            {
                new DefaultRule(),
                new isWomanRule(),
                new TeacherRule(),

                new BD1959Rule(),

            };
        }

        public PensionInfo Calc(UserInfo userinfo)
        {
            var result = new PensionInfo();

            // правила для текущего человека
            var currentRules = new List<IPensionRule>();

            // собрать все правила Rule

            // правила по полу
            var sexRules = Rules.OfType<ISexRule>();

            //все остальные правила
            var otherRules = Rules.Except(sexRules);

            //правила по полу для текущего человека
            var currentSexRules = sexRules.Where(rule => rule.sex == userinfo.Sex);

            currentRules.AddRange(otherRules);
            currentRules.AddRange(currentSexRules);

            foreach (var rule in currentRules)
            {
                result = rule.Apply(result, userinfo);
                // применить каждое правило к инфе
                // результат должен быть сквозным
                
            }
            
            return result;
        }

    }
}

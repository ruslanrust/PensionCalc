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
        public PensionInfo Calc(UserInfo userinfo)
        {
            var result = new PensionInfo();

            var age = userinfo.Sex == Sex.Woman ? 63 : 65;

            var years = userinfo.Birthday.AddYears(age) - DateTime.Today;

            result.RemainingYears = years;

            // собрать все правиоа
            // применить каждое правило к инфе
            // результат должен быть сквозным
            // как все проверили формируем результат
            // в человеческом виде

            return result;
        }

    }
}

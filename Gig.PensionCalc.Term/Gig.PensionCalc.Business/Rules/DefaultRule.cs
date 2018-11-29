using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class DefaultRule : IPensionRule
    {
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userinfo)
        {
            var years = userinfo.Birthday.AddYears(65) - DateTime.Today;

            pensionInfo.RemainingYears = years;
            pensionInfo.Info += "Стандартный возраст выхода на пенсию - 65" + Environment.NewLine;

            return pensionInfo;

        }
    }
}

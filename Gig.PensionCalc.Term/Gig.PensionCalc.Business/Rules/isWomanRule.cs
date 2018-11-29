using System;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class isWomanRule : ISexRule
    {
        public Sex sex => Sex.Woman;
        
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userinfo)
        {
            pensionInfo.RemainingYears = pensionInfo.RemainingYears.Add(new TimeSpan(-365 * 2, 0, 0, 0));
            pensionInfo.Info += "Скидка дамам - 2 года" + Environment.NewLine;

            return pensionInfo;

        }
    }
}

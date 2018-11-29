using System;
using Gig.PensionCalc.Domain;

namespace Gig.PensionCalc.Business.Rules
{
    public class BD1959Rule : IPensionRule
    {
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userinfo)
        {
            if (userinfo.Sex == Sex.Man && userinfo.Birthday.Year == 1959)
            {
                pensionInfo.RemainingYears = new DateTime(2020, 1, 1) - DateTime.Today;
                pensionInfo.Info += "Успел родиться в 1959 - выходи в 2020" + Environment.NewLine;
            }

            if (userinfo.Sex == Sex.Woman && userinfo.Birthday.Year == 1964)
            {
                pensionInfo.RemainingYears = new DateTime(2020, 1, 1) - DateTime.Today;
                pensionInfo.Info += "Успел родиться в 1964 - выходи в 2020" + Environment.NewLine;
            }

            return pensionInfo;
        }
    }
}

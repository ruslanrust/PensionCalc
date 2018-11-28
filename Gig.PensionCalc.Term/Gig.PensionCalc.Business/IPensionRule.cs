using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Business
{
    /// <summary>
    /// Правило начисления пенсии
    /// </summary>
    public interface IPensionRule
    {
        /// <summary>
        /// Применить правило
        /// </summary>
        /// <param name="pensionInfo">Информация о пенсии</param>
        /// <param name="userinfo">Информация о человеке</param>
        /// <returns>Измененная информация о пенсии</returns>
        PensionInfo Apply(PensionInfo pensionInfo, UserInfo userinfo);
    }
}

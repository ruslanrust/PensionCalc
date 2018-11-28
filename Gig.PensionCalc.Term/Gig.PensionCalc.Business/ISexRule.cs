using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Business
{
    /// <summary>
    /// Правило начисления пенсии на основе пола
    /// </summary>
    public interface ISexRule : IPensionRule
    {
        /// <summary>
        /// Правило пола
        /// </summary>
        Sex sex { get; }
        
    }
}

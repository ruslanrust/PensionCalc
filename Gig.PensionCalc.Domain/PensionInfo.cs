﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Domain
{
    /// <summary>
    /// Информация о пенсии
    /// </summary>
    public class PensionInfo
    {
        /// <summary>
        /// Сколько лет осталось работать
        /// </summary>
        public TimeSpan RemainingYears { get; set; }

        /// <summary>
        /// Стаж
        /// </summary>
        public TimeSpan ExpirenceYears { get; set; }

        public string Info { get; set; }

        public override string ToString()
        {
            return $"Еще работать {RemainingYears.TotalDays / 365} год;" + 
                Environment.NewLine + Info;
        }


    }
}

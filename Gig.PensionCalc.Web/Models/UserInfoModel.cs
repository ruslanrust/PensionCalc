using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gig.PensionCalc.Web.Models
{
    public class UserInfoModel
    {
        /// <summary>
        /// ФИО
        /// </summary>
        [MinLength(2)]
        [Display(Name = "Имя")]

        public string Name { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Без даты рождения мы не можем вычислить ничего")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        [Required(ErrorMessage = "Очень надо")]
        [Display(Name = "Пол")] 
        public Sex Sex { get; set; }

        /// <summary>
        /// Места работы
        /// </summary>
        public Work[] Works { get; set; }
    }
}
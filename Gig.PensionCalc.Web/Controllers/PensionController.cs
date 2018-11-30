using Gig.PensionCalc.Business;
using Gig.PensionCalc.Domain;
using Gig.PensionCalc.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gig.PensionCalc.Web.Controllers
{
    public class PensionController : Controller
    {
        // GET: Pension
        public ActionResult Index()
        {
            //HttpContext.Request.Form;
            //HttpContext.Request.QueryString;
            //HttpContext.Request.Cookies;
            //HttpContext.Request.Files

            return View();
        }

        [HttpPost]
        public ActionResult Info(UserInfoModel info)
        {
            if (info.Birthday < new System.DateTime(1850, 0))
            {
                ModelState.AddModelError("Birthday", "Да ну нафиг?!");
            }

            if (info.Sex == Sex.Unknown)
            {
                ModelState.AddModelError("", "Ты что вообще такое?");
            }

            if (!ModelState.IsValid)
            {
                return View("Index", info);
            }

            var man = new UserInfo
            {
                Name = info.Name,
                Sex = info.Sex,
                Birthday = info.Birthday,
                Works = info.Works
            };

            var calc = new Calculator();
            var pensionInfo = calc.Calc(man);

            return View(pensionInfo);
        }
    }
}
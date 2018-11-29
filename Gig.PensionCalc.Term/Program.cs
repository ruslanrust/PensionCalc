﻿using Gig.PensionCalc.Business;
using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Term
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            bool isWoman;

            

            #region Ввод значений
            if (args.Length == 3)
            {
                name = args[0];

                age = int.Parse(args[1]);

                isWoman = bool.Parse(args[2]);
            }
            else
            {
                Console.WriteLine("Напишите имя");
                name = Console.ReadLine();

                Console.WriteLine("Напишите сколько вам лет");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Укажите ваш пол (М/Ж): ");
                isWoman = Console.ReadLine().ToLowerInvariant() == "ж";

            }
            #endregion



            var man = new UserInfo
            {
                Name = name,
                Sex = isWoman ? Sex.Woman : Sex.Man,
                Birthday = DateTime.Today.AddYears(-age)
            };

            var calc = new Calculator();
            var pensionInfo = calc.Calc(man);

            var result = $"{man.Name}, {Environment.NewLine} {pensionInfo}";
            Console.WriteLine(result);

             
        }
    }
}

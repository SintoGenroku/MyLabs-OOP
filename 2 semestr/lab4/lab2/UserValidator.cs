using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class UserValidator
    {
        
        [Required(ErrorMessage = "Заполните поле \"ФИО\"")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Заполните поле \"Номер паспорта\"")]
        public string Passport { get; set; }

        [Required(ErrorMessage = "Заполните поле \"Гражданство\"")]
        [RegularExpression(@"(рб)|(Рб)|(РБ){1}", ErrorMessage = "Наш банк работает только с гражданами РБ")]
        public string Nation { get; set; }

        [Required(ErrorMessage = "Выберите длительность вклада")]
        public string Contribution { get; set; }

        [Required(ErrorMessage = "Выберите тип процентной ставки")]
        public string InterestRate { get; set; }

        public UserValidator(string fullname, string passport, string nation, string contribution, string interestrate) 
        { 
            Fullname = fullname;
            Passport = passport;
            Nation = nation;
            Contribution = contribution;
            InterestRate = interestrate;

        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace lab2
{
    public class UserValidator
    {
        

        [Required(ErrorMessage = "Заполните поле \"ФИО\"")]
        [UserName]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Заполните поле \"Номер паспорта\"")]
        [RegularExpression(@"\d{7}\w{1}\d{3}(PB|BA|BI)\d{1}", ErrorMessage = "Некоректный номер паспорта")]
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

    public class UserNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string userName)
            {
                var fullname = userName.Split(' ');
                if (fullname.Count()==3)    
                    return true;
                else
                    ErrorMessage = "Введите полное ФИО";
            }
            return false;
        }
    }
}

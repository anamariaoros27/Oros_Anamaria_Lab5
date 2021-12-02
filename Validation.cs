using System;
using System.Windows.Controls;

namespace Oros_Anamaria_Lab5
{
    //validator pentru camp required
    public class StringNotEmpty : ValidationRule
    {
        //mostenim din clasa ValidationRule
        //suprascriem metoda Validate ce returneaza un ValidationResult

        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == "")
            return new ValidationResult(false, "String cannot be empty");
            return new ValidationResult(true, null);
        }
    }

    //validator pentru lungime minima a string-ului
    public class StringMinLength : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length < 3)
                return new ValidationResult(false, "String must have at least 3 characters!");
                return new ValidationResult(true, null);
        }
    }

    public class StringMaxLength : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length > 20)
                return new ValidationResult(false, "String must have maximum 10 characters!");
            return new ValidationResult(true, null);
        }
    }

    public class StringNotNull : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == null)
                return new ValidationResult(false, "String must not be null!");
            return new ValidationResult(true, null);
        }
    }
}

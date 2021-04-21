using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SWarehouse.Validations
{
    public class EmptyRuleValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) => new ValidationResult(!String.IsNullOrWhiteSpace(value?.ToString()), "Vui Lòng Nhập Thông Tin");
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SWarehouse.Validations
{
   public class NullSelectedItemValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) => new ValidationResult(value != null, "Vui Chọn Thông Tin");
   }
}

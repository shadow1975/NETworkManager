﻿using NETworkManager.Models.Settings;
using NETworkManager.Utilities;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace NETworkManager.Validators
{
    public class OIDValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (Regex.IsMatch(value as string, RegexHelper.OIDRegex))
                return ValidationResult.ValidResult;

            return new ValidationResult(false, LocalizationManager.GetStringByKey("String_ValidationError_EnterValidOID"));
        }
    }
}

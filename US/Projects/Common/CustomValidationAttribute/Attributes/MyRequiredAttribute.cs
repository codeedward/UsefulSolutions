using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidationAttribute.Attributes
{
    public class MyRequiredAttribute : RequiredAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // anything could be executed here
            return base.IsValid(value, validationContext);
        }
    }
}
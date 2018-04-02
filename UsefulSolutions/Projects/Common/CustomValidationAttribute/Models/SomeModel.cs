using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CustomValidationAttribute.Attributes;

namespace CustomValidationAttribute.Models
{
    public class SomeModel
    {
        public string NoValidationField { get; set; }

        [Required]
        public string RequiredField { get; set; }

        [DataType(DataType.Date)]
        public string DateTime { get; set; }

        [MyRequired]
        public string MyRequiredField { get; set; }

        //[DataType(DataType.Date)]
        public string MyDateTime { get; set; }
    }
}
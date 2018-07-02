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

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MyRequired]
        public string MyRequiredField { get; set; }

        [MyData(DataType.EmailAddress, ErrorMessage = "Please enter a valid email test")]
        public string MyEmail { get; set; }


        [DataType(DataType.Date, ErrorMessage = "Please enter a valid dateTime test")]
        public DateTime DateTime { get; set; }

        [Display(Name = "My date")]
        [Required]
        [MyData(DataType.Date, ErrorMessage = "Please enter a valid dateTime test")]
        public DateTime MyDateTime { get; set; }
    }
}
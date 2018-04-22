using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidationAttribute.Attributes
{
    public class MyDataAttribute : DataTypeAttribute
    {
        private DataType dataType;
        public MyDataAttribute(DataType dataType) : base(dataType)
        {
            this.dataType = dataType;
        }

        public MyDataAttribute(string customDataType) : base(customDataType)
        {
        }

        public override bool IsValid(object value)
        {
            if (this.dataType == DataType.EmailAddress)
            {
                return false;
            }

            return base.IsValid(value);
        }

    }
}
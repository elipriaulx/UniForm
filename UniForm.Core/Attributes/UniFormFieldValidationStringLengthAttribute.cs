using System;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UniFormFieldValidationStringLengthAttribute : UniFormAttributeBase
    {
        public double MinLength { get; }
        public double MaxLength { get; }

        public UniFormFieldValidationStringLengthAttribute(double minLength, double maxLength)
        {
            MinLength = minLength;
            MaxLength = maxLength;
        }
    }
}
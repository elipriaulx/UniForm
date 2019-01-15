using System;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldValidationStringLengthAttribute : UniFormFieldValidationAttributeBase
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
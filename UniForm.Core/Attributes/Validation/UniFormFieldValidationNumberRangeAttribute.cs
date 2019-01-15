using System;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldValidationNumberRangeAttribute : UniFormFieldValidationAttributeBase
    {
        public double MinValue { get; }
        public double MaxValue { get; }
        public bool MinInclusive { get; }
        public bool MaxInclusive { get; }

        public UniFormFieldValidationNumberRangeAttribute(double minValue, double maxValue, bool minInclusive = true, bool maxInclusive = false)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            MinInclusive = minInclusive;
            MaxInclusive = maxInclusive;
        }
    }
}

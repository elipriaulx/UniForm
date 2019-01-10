using System;
using System.Collections.Generic;
using System.Text;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UniFormFieldValidationNumberRangeAttribute : UniFormAttributeBase
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

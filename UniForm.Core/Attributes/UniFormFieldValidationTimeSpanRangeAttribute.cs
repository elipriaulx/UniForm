using System;

namespace UniForm.Core.Attributes {
    [AttributeUsage(AttributeTargets.Property)]
    public class UniFormFieldValidationTimeSpanRangeAttribute : UniFormAttributeBase
    {
        public TimeSpan MinValue { get; }
        public TimeSpan MaxValue { get; }
        public bool MinInclusive { get; }
        public bool MaxInclusive { get; }

        public UniFormFieldValidationTimeSpanRangeAttribute(TimeSpan minValue, TimeSpan maxValue, bool minInclusive = true, bool maxInclusive = false)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            MinInclusive = minInclusive;
            MaxInclusive = maxInclusive;
        }
    }
}
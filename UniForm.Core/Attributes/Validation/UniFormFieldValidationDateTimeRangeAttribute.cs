﻿using System;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldValidationDateTimeRangeAttribute : UniFormFieldValidationAttributeBase
    {
        public DateTime MinValue { get; }
        public DateTime MaxValue { get; }
        public bool MinInclusive { get; }
        public bool MaxInclusive { get; }

        public UniFormFieldValidationDateTimeRangeAttribute(DateTime minValue, DateTime maxValue, bool minInclusive = true, bool maxInclusive = false)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            MinInclusive = minInclusive;
            MaxInclusive = maxInclusive;
        }
    }
}

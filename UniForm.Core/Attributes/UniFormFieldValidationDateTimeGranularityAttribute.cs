using System;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UniFormFieldValidationDateTimeGranularityAttribute : UniFormAttributeBase
    {
        public DateTimeGranularity Granularity { get; }

        public UniFormFieldValidationDateTimeGranularityAttribute(DateTimeGranularity granularity)
        {
            Granularity = granularity;
        }
    }
}

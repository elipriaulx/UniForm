using System;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class UniFormFieldValidationStringNotContainsAttribute : UniFormAttributeBase
    {
        public string Pattern { get; }

        public UniFormFieldValidationStringNotContainsAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}
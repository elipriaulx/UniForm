using System;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class UniFormFieldValidationStringContainsAttribute : UniFormAttributeBase
    {
        public string Pattern { get; }

        public UniFormFieldValidationStringContainsAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}
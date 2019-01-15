using System;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class UniFormFieldValidationStringContainsAttribute : UniFormFieldValidationAttributeBase
    {
        public string Pattern { get; }

        public UniFormFieldValidationStringContainsAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}
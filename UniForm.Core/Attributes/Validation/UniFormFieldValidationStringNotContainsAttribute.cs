using System;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class UniFormFieldValidationStringNotContainsAttribute : UniFormFieldValidationAttributeBase
    {
        public string Pattern { get; }

        public UniFormFieldValidationStringNotContainsAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}
using System;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class UniFormFieldValidationMethodAttribute : UniFormFieldValidationAttributeBase
    {
        public string MethodName { get; }

        public UniFormFieldValidationMethodAttribute(string methodName)
        {
            MethodName = methodName;
        }
    }
}

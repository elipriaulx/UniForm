using System;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class UniFormValidationMethodAttribute : UniFormValidationAttributeBase
    {
        public string MethodName { get; }

        public UniFormValidationMethodAttribute(string methodName)
        {
            MethodName = methodName;
        }
    }
}
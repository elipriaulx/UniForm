using System;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class UniFormFieldValidationMethodAttribute : UniFormAttributeBase
    {
        public string MethodName { get; }

        public UniFormFieldValidationMethodAttribute(string methodName)
        {
            MethodName = methodName;
        }
    }
}

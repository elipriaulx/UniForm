using System;

namespace UniForm.Core.Attributes {
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class UniFormValidationMethodAttribute : UniFormAttributeBase
    {
        public string MethodName { get; }

        public UniFormValidationMethodAttribute(string methodName)
        {
            MethodName = methodName;
        }
    }
}
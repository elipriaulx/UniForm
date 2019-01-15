using System;

namespace UniForm.Core.Attributes.Composition
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class UniFormFieldSourceCollectionAttribute : UniFormCompositionAttributeBase
    {
        public string TargetPropertyName { get; }

        public UniFormFieldSourceCollectionAttribute(string targetPropertyName)
        {
            TargetPropertyName = targetPropertyName;
        }
    }
}

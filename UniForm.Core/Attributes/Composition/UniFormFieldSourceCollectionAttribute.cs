using System;

namespace UniForm.Core.Attributes.Composition
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class UniFormFieldSourceCollectionAttribute : UniFormCompositionAttributeBase
    {
        public string TargetPropertyName { get; }

        public string DefaultDisplayMemberName { get; }

        public UniFormFieldSourceCollectionAttribute(string targetPropertyName, string defaultDisplayMemberName = null)
        {
            TargetPropertyName = targetPropertyName;
            DefaultDisplayMemberName = defaultDisplayMemberName;
        }
    }
}

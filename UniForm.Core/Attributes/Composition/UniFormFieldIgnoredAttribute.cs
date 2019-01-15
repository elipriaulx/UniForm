using System;

namespace UniForm.Core.Attributes.Composition
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldIgnoredAttribute : UniFormCompositionAttributeBase
    {
        public UniFormFieldIgnoredAttribute()
        {

        }
    }
}
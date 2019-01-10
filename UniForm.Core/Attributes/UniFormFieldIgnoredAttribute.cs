using System;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldIgnoredAttribute : UniFormAttributeBase
    {
        public UniFormFieldIgnoredAttribute()
        {

        }
    }
}
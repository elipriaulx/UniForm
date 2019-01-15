using System;
using UniForm.Core.Models;

namespace UniForm.Core.Attributes.Composition
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldAttribute : UniFormCompositionAttributeBase
    {
        public string Name { get; }
        public string Description { get; }
        public int Priority { get; }
        public UniFormFieldTypes Type { get; }

        public UniFormFieldAttribute(string name = null, string description = null, int priority = int.MaxValue, UniFormFieldTypes type = UniFormFieldTypes.AutoPrimitive)
        {
            Name = name;
            Description = description;
            Priority = priority;
            Type = type;
        }
    }
}
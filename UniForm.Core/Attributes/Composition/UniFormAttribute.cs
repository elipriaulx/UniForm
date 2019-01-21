using System;
using UniForm.Core.Models;

namespace UniForm.Core.Attributes.Composition
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class UniFormAttribute : UniFormCompositionAttributeBase
    {
        public string Name { get; }
        public string Description { get; }
        public bool AutomaticPropertyInclusion { get; }
        public UniFormFieldOrder FieldOrder { get; }

        public UniFormAttribute(string name = null, string description = null, bool automaticPropertyInclusion = false, UniFormFieldOrder fieldOrder = UniFormFieldOrder.PriorityThenName)
        {
            Name = name;
            Description = description;
            AutomaticPropertyInclusion = automaticPropertyInclusion;
            FieldOrder = fieldOrder;
        }
    }
}

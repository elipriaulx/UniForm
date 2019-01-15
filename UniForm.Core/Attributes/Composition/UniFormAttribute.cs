using System;

namespace UniForm.Core.Attributes.Composition
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class UniFormAttribute : UniFormCompositionAttributeBase
    {
        public string Name { get; }
        public string Description { get; }
        public bool AutomaticPropertyInclusion { get; }

        public UniFormAttribute(string name = null, string description = null, bool automaticPropertyInclusion = false)
        {
            Name = name;
            Description = description;
            AutomaticPropertyInclusion = automaticPropertyInclusion;
        }
    }
}

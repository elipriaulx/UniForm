using System;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldAttribute : UniFormAttributeBase
    {
        public string Name { get; }
        public string Description { get; }
        public int Priority { get; }

        public UniFormFieldAttribute(string name = null, string description = null, int priority = int.MaxValue)
        {
            Name = name;
            Description = description;
            Priority = priority;
        }
    }
}
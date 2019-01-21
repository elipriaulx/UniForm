using System.Reflection;

namespace UniForm.Engine.Forms
{
    public sealed class UniFormFieldUint : UniFormField<uint>
    {
        internal UniFormFieldUint(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }
}
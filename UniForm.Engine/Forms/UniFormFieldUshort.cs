using System.Reflection;

namespace UniForm.Engine.Forms
{
    public sealed class UniFormFieldUshort : UniFormField<ushort>
    {
        internal UniFormFieldUshort(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }
}
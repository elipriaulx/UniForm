using System.Reflection;

namespace UniForm.Engine.Forms
{
    public sealed class UniFormFieldShort : UniFormField<short>
    {
        internal UniFormFieldShort(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }
}
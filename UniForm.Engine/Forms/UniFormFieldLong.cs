using System.Reflection;

namespace UniForm.Engine.Forms
{
    public sealed class UniFormFieldLong : UniFormField<long>
    {
        internal UniFormFieldLong(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }
}
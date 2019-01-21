using System.Reflection;

namespace UniForm.Engine.Forms
{
    public sealed class UniFormFieldDouble : UniFormField<double>
    {
        internal UniFormFieldDouble(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }
}
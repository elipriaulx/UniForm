using System.Reflection;

namespace UniForm.Engine.Forms
{
    public sealed class UniFormFieldChar : UniFormField<char>
    {
        internal UniFormFieldChar(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }
}
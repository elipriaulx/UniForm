using System.Reflection;

namespace UniForm.Engine.Forms
{
    public sealed class UniFormFieldString : UniFormField<string>
    {
        public bool IsMultiline { get; }
        public bool IsBlob { get; }

        internal UniFormFieldString(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue, bool isMultiline = false, bool isBlob = false)
            : base(info, target, name, description, priority)
        {
            IsMultiline = isMultiline;
            IsBlob = isBlob;
        }
    }
}
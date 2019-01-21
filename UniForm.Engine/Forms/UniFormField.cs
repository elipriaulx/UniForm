using System.Reflection;

namespace UniForm.Engine.Forms
{
    public abstract class UniFormField : UniFormObjectBase
    {
        protected UniFormField(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
        {
            Info = info;
            Target = target;
            Name = name;
            Description = description;
            Priority = priority;
        }

        protected PropertyInfo Info { get; }

        protected object Target { get; }

        public int Priority { get; }

        public string Name { get; }

        public string Description { get; }

        public abstract void ForceRead();

        public abstract void ForceWrite();
    }

    public abstract class UniFormField<T> : UniFormField
    {
        private T _value;

        protected UniFormField(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue) : base(info, target, name, description, priority)
        {
            ForceRead();
        }

        public T Value
        {
            get => _value;

            set
            {
                // TODO: Add validation
                _value = value;
                Info.SetValue(Target, value);
                OnPropertyChanged();
            }
        }

        public sealed override void ForceRead()
        {
            Value = (T)Info.GetValue(Target);
        }

        public sealed override void ForceWrite()
        {
            Info.SetValue(Target, _value);
        }
    }
}
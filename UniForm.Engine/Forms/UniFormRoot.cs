using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UniForm.Engine.Forms
{
    public abstract class UniFormObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class UniFormRoot : UniFormObjectBase
    {
        internal UniFormRoot(UniFormField[] fields, string name = null, string description = null)
        {
            _fields = fields;
            Name = name;
            Description = description;
        }

        private UniFormField[] _fields;

        public string Name { get; }

        public string Description { get; }

        public IEnumerable<UniFormField> Fields => _fields;

        public void ForceRead()
        {
            foreach (var f in _fields) f.ForceRead();
        }

        public void ForceWrite()
        {
            foreach (var f in _fields) f.ForceWrite();
        }
    }

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
            Value = (T) Info.GetValue(Target);
        }

        public sealed override void ForceWrite()
        {
            Info.SetValue(Target, _value);
        }
    }

    public sealed class UniFormFieldBool : UniFormField<bool>
    {
        internal UniFormFieldBool(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldByte : UniFormField<byte>
    {
        internal UniFormFieldByte(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldChar : UniFormField<char>
    {
        internal UniFormFieldChar(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldShort : UniFormField<short>
    {
        internal UniFormFieldShort(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldUshort : UniFormField<ushort>
    {
        internal UniFormFieldUshort(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldInt : UniFormField<int>
    {
        internal UniFormFieldInt(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldUint : UniFormField<uint>
    {
        internal UniFormFieldUint(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldLong : UniFormField<long>
    {
        internal UniFormFieldLong(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldUlong : UniFormField<ulong>
    {
        internal UniFormFieldUlong(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldFloat : UniFormField<float>
    {
        internal UniFormFieldFloat(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldDouble : UniFormField<double>
    {
        internal UniFormFieldDouble(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldString : UniFormField<string>
    {
        internal UniFormFieldString(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }

    public sealed class UniFormFieldEnum : UniFormField<Enum>
    {
        internal UniFormFieldEnum(PropertyInfo info, object target, string name, string description = null, int priority = int.MaxValue)
            : base(info, target, name, description, priority)
        {
        }
    }
}

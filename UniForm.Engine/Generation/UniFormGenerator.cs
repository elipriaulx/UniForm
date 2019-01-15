using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UniForm.Core.Attributes.Composition;
using UniForm.Core.Models;
using UniForm.Engine.Forms;

namespace UniForm.Engine.Generation
{
    public class UniFormGenerator
    {
        public UniFormRoot CreateForm(object o)
        {
            var oType = o.GetType();

            var props = oType.GetProperties();
            var meta = oType.GetCustomAttribute<UniFormAttribute>() ?? new UniFormAttribute(null, null, true);

            var fieldList = new List<UniFormField>();

            foreach (var p in props)
            {
                var r = TryDecode(p, o, meta.AutomaticPropertyInclusion);

                if (r == null) continue;

                fieldList.Add(r);
            }

            return new UniFormRoot(fieldList.OrderBy(x => x.Priority).ThenBy(x => x.Name).ToArray());
        }
        
        private static UniFormField TryDecode(PropertyInfo i, object o, bool autoInclude)
        {
            var t = i.PropertyType;

            var ignoreField = i.GetCustomAttribute<UniFormFieldIgnoredAttribute>();
            if (ignoreField != null) return null;

            var ffa = i.GetCustomAttribute<UniFormFieldAttribute>();
            if (!autoInclude && ffa == null) return null;
            
            var name = ffa?.Name ?? i.Name;
            var description = ffa?.Description;
            var priority = ffa?.Priority ?? int.MaxValue;
            var type = ffa?.Type ?? Core.Models.UniFormFieldTypes.AutoCollection;

            UniFormField f = null;

            if (t == typeof(bool))
            {
                f = new UniFormFieldBool(i, o, name, description, priority);
            }
            else if (t == typeof(byte))
            {
                f = new UniFormFieldByte(i, o, name, description, priority);
            }
            else if(t == typeof(char))
            {
                f = new UniFormFieldChar(i, o, name, description, priority);
            }
            else if (t == typeof(short))
            {
                f = new UniFormFieldShort(i, o, name, description, priority);
            }
            else if(t == typeof(ushort))
            {
                f = new UniFormFieldUshort(i, o, name, description, priority);
            }
            else if (t == typeof(int))
            {
                f = new UniFormFieldInt(i, o, name, description, priority);
            }
            else if (t == typeof(uint))
            {
                f = new UniFormFieldUint(i, o, name, description, priority);
            }
            else if (t == typeof(long))
            {
                f = new UniFormFieldLong(i, o, name, description, priority);
            }
            else if (t == typeof(ulong))
            {
                f = new UniFormFieldUlong(i, o, name, description, priority);
            }
            else if (t == typeof(float))
            {
                f = new UniFormFieldFloat(i, o, name, description, priority);
            }
            else if (t == typeof(double))
            {
                f = new UniFormFieldDouble(i, o, name, description, priority);
            }
            else if (t == typeof(string))
            {
                var isMultiline = type == UniFormFieldTypes.MultiLineString;
                var isBlob = type == UniFormFieldTypes.BlobString;

                f = new UniFormFieldString(i, o, name, description, priority, isMultiline || isBlob, isBlob);
            }
            else if (t.BaseType == typeof(Enum))
            {
                f = new UniFormFieldEnum(i, o, name, description, priority);
            }

            return f;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UniForm.Core.Attributes.Composition;
using UniForm.Core.Models;
using UniForm.Engine.Forms;

namespace UniForm.Engine.Generation
{
    public class FormGenerator
    {

        public UniFormRoot CreateForm(object o)
        {
            var oType = o.GetType();

            var props = oType.GetProperties();
            var meta = oType.GetCustomAttribute<UniFormAttribute>() ?? new UniFormAttribute(null, null, true, UniFormFieldOrder.None);
            var propMeta = props.Select(p => new CandidateFieldData(p)).ToList();

            var fieldList = new Dictionary<string, UniFormField>();
            
            foreach (var p in propMeta)
            {
                if (p.IsExplicitlyIgnored || (!meta.AutomaticPropertyInclusion && !p.IsUniFormFieldAttributePresent)) continue;
                
                var r = TryDecode(p, o);

                if (r == null) continue;

                fieldList.Add(p.Name, r);
            }

            IEnumerable<UniFormField> v = fieldList.Values;

            switch (meta.FieldOrder)
            {
                case UniFormFieldOrder.None:
                    break;
                case UniFormFieldOrder.Name:
                    v = v.OrderBy(x => x.Name);
                    break;
                case UniFormFieldOrder.NameThenPriority:
                    v = v.OrderBy(x => x.Name).ThenBy(x => x.Priority);
                    break;
                case UniFormFieldOrder.Priority:
                    v = v.OrderBy(x => x.Priority);
                    break;
                case UniFormFieldOrder.PriorityThenName:
                    v = v.OrderBy(x => x.Priority).ThenBy(x => x.Name);
                    break;
                default:
                    // TODO
                    break;
            }

            return new UniFormRoot(v.ToArray());
        }
        
        private static UniFormField TryDecode(CandidateFieldData fieldData, object o)
        {
            var t = fieldData.PropertyType;
            var i = fieldData.ReflectedPropertyInfo;

            var name = fieldData.Name;
            var description = fieldData.Description;
            var priority = fieldData.Priority;
            var type = fieldData.DesiredFieldType;

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

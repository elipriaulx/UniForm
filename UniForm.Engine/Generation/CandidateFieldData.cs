using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UniForm.Core.Attributes.Composition;
using UniForm.Core.Models;

namespace UniForm.Engine.Generation
{
    public class CandidateFieldData
    {
        private readonly PropertyInfo _propertyInfo;

        public string PropertyName { get; }
        public Type PropertyType { get; }
        public PropertyInfo ReflectedPropertyInfo => _propertyInfo;

        public bool IsUniFormFieldAttributePresent { get; }
        public string Name { get; }
        public string Description { get; }
        public int Priority { get; }
        public UniFormFieldTypes DesiredFieldType { get; }

        public bool IsExplicitlyIgnored { get; }
        
        public IReadOnlyList<UniFormFieldSourceCollectionAttribute> SourceFor { get; }

        public CandidateFieldData(PropertyInfo propertyInfo)
        {
            _propertyInfo = propertyInfo;

            PropertyName = _propertyInfo.Name;
            PropertyType = _propertyInfo.PropertyType;
            
            var formFieldAttribute = propertyInfo.GetCustomAttribute<UniFormFieldAttribute>();

            IsUniFormFieldAttributePresent = formFieldAttribute != null;
            Name = formFieldAttribute?.Name ?? propertyInfo.Name;
            Description = formFieldAttribute?.Description;
            Priority = formFieldAttribute?.Priority ?? int.MaxValue;
            DesiredFieldType = formFieldAttribute?.Type ?? UniFormFieldTypes.AutoPrimitive;

            IsExplicitlyIgnored = propertyInfo.GetCustomAttribute<UniFormFieldIgnoredAttribute>() != null;
            SourceFor = propertyInfo.GetCustomAttributes<UniFormFieldSourceCollectionAttribute>().ToList();
        }
    }
}
using System;
using System.ComponentModel;
using System.Linq;

namespace UniForm.Wpf.Controls.Models
{
    public class EnumItem
    {
        public string Name { get; }

        public string Description { get; }

        public Enum Value { get; }

        public EnumItem(Enum value)
        {
            var name = value.ToString();
            var displayNameAttribute = value.GetType().GetField(name).GetCustomAttributes(typeof(DisplayNameAttribute), false).FirstOrDefault() as DisplayNameAttribute;
            var descriptionAttribute = value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

            Value = value;
            Name = displayNameAttribute?.DisplayName ?? name;
            Description = descriptionAttribute?.Description ?? name;
        }
    }
}

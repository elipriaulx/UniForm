using System;
using System.Collections.Generic;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldValidationStringNotContainsCharactersAttribute : UniFormFieldValidationAttributeBase
    {
        public HashSet<char> Set { get; }

        public UniFormFieldValidationStringNotContainsCharactersAttribute(string characters)
        {
            Set = new HashSet<char>(characters);
        }

        public UniFormFieldValidationStringNotContainsCharactersAttribute(char character)
        {
            Set = new HashSet<char>
            {
                character
            };

        }

        public UniFormFieldValidationStringNotContainsCharactersAttribute(char[] characters)
        {
            Set = new HashSet<char>(characters);
        }
    }
}
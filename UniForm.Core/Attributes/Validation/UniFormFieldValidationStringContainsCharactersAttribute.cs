using System;
using System.Collections.Generic;

namespace UniForm.Core.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UniFormFieldValidationStringContainsCharactersAttribute : UniFormFieldValidationAttributeBase
    {
        public HashSet<char> Set { get; }

        public UniFormFieldValidationStringContainsCharactersAttribute(string characters)
        {
            Set = new HashSet<char>(characters);
        }

        public UniFormFieldValidationStringContainsCharactersAttribute(char character)
        {
            Set = new HashSet<char>
            {
                character
            };

        }

        public UniFormFieldValidationStringContainsCharactersAttribute(char[] characters)
        {
            Set = new HashSet<char>(characters);
        }
    }
}
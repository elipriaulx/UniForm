using System;
using System.Collections.Generic;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UniFormFieldValidationStringNotContainsCharactersAttribute : UniFormAttributeBase
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
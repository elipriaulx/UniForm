using System;
using System.Collections.Generic;

namespace UniForm.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UniFormFieldValidationStringContainsCharactersAttribute : UniFormAttributeBase
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
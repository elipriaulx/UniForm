using System;
using UniForm.Core.Attributes;

namespace UniForm.Wpf.Models
{
    [UniForm("Example Form", "An example UniForm form.", false)]
    public class ExampleConfigurationWithRootAttribtue
    {
        public int BeaverCount { get; set; } = 4;

        [UniFormField("Magic Number", "A Magic Number that must definitely not be 3.")]
        public int MagicNumber { get; set; } = 23;

        [UniFormField("Cat Name", "The name of your cat.")]
        public string CatName { get; set; } = "Barry";

        [UniFormField("Decimal", "This number must not be an integer.")]
        [UniFormFieldValidationMethod(nameof(EnsureIsDecimal))]
        public double SomeDecimal { get; set; } = 0.2;

        public static bool EnsureIsDecimal(double instanceValue)
        {
            var d = instanceValue;
            return  d - Math.Truncate(d) != 0;
        }

    }
}

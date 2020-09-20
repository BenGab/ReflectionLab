using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ReflectionLab.Validator
{
    internal class RangeValidator : IValidator
    {
        private readonly RangeAttribute _rangeAttribute;

        public RangeValidator(RangeAttribute rangeAttribute)
        {
            _rangeAttribute = rangeAttribute;
        }
        
        public bool Validate<T>(T instance, PropertyInfo property)
        {
            int length = property.GetValue(instance).ToString().Length;
            return (int)_rangeAttribute.Minimum < length && (int)_rangeAttribute.Maximum > length;
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ReflectionLab.Validator
{
    internal class MaxLengthValidator : IValidator
    {
        private readonly int maxLength;

        public MaxLengthValidator(MaxLengthAttribute maxLengthAttribute)
        {
            maxLength = maxLengthAttribute.Length;
        }

        public bool Validate<T>(T instance, PropertyInfo property)
        {
            return property.GetValue(instance).ToString().Length <= maxLength;
        }
    }
}

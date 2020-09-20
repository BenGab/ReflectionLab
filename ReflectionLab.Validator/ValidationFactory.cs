using System;
using System.ComponentModel.DataAnnotations;

namespace ReflectionLab.Validator
{
    public class ValidationFactory
    {
        public IValidator GetValidator(Attribute attribute)
        {
            if(attribute is MaxLengthAttribute)
            {
                return new MaxLengthValidator((MaxLengthAttribute)attribute);
            }

            if(attribute is RangeAttribute)
            {
                return new RangeValidator((RangeAttribute)attribute);
            }

            return null;
        }
    }
}

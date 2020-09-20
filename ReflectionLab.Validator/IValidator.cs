using System.Reflection;

namespace ReflectionLab.Validator
{
    public interface IValidator
    {
        bool Validate<T>(T instance, PropertyInfo property);
    }
}

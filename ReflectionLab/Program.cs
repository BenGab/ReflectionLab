using LABXMLASerializer;
using ReflectionLab.Models;
using ReflectionLab.Validator;
using System;
using System.Reflection;

namespace ReflectionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. XMLSerializer
            Person person = new Person
            {
                Name = "Sanyi",
                Department = "Kőműves",
                Room = "Buszos kocsma"
            };

            LabXMLSerializer ser = new LabXMLSerializer();
            var xml = ser.ToXML(person);

            Console.WriteLine(xml);

            //2. Validator
            ValidationFactory fac = new ValidationFactory();
            foreach(PropertyInfo propertyInfo in person.GetType().GetProperties())
            {
                foreach(Attribute attr in propertyInfo.GetCustomAttributes<Attribute>())
                {
                    IValidator validator = fac.GetValidator(attr);

                    validator?.Validate(person, propertyInfo);
                }
            }
        }
    }
}

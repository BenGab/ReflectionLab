using LABXMLASerializer.Attributes;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;

namespace LABXMLASerializer
{
    public class LabXMLSerializer
    {
        private bool IsAllowed(PropertyInfo property)
        {
            return property.GetCustomAttribute<ExcludeXMLAttribute>() == null;
        }

        private string GetPrettyName(PropertyInfo property)
        {
            var attr = property.GetCustomAttribute<DisplayNameAttribute>();

            return attr != null ? attr.DisplayName : property.Name;
        }

        public XElement ToXML<T>(T instance) where T : class
        {
            if (instance == null)
            {
                throw new ArgumentException(nameof(instance));
            }

            XElement node = new XElement("instance");
            Type instanceType = instance.GetType();

            foreach(PropertyInfo property in instanceType.GetProperties())
            {
                if(IsAllowed(property))
                {
                    XElement dataNode = new XElement("data");
                    dataNode.Add(new XAttribute("name", property.Name));
                    dataNode.Add(new XAttribute("prettyName", GetPrettyName(property)));
                    dataNode.Value = property.GetValue(instance).ToString();
                    node.Add(dataNode);
                }
            }

            return node;
        }
    }
}

using System;

namespace LABXMLASerializer.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple =true)]
    public class ExcludeXMLAttribute : Attribute
    {
        public string Reason { get; set; }
    }
}

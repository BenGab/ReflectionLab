using LABXMLASerializer;
using ReflectionLab.Models;
using System;

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
        }
    }
}

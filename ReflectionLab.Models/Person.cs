using System.ComponentModel;

namespace ReflectionLab.Models
{
    public class Person
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Deparment")]
        public string Department { get; set; }

        [DisplayName("Room")]
        public string Room { get; set; }
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReflectionLab.Models
{
    public class Person
    {
        [DisplayName("Name")]
        [Range(10, 50)]
        public string Name { get; set; }

        [DisplayName("Deparment")]
        [MaxLength(100)]
        public string Department { get; set; }

        [DisplayName("Room")]
        public string Room { get; set; }
    }
}

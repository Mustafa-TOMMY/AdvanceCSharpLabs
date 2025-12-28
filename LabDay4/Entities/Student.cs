using System.ComponentModel.DataAnnotations;

namespace LabDay4.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}

using StudentsApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsApp.Models
{
    public class Student : Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}

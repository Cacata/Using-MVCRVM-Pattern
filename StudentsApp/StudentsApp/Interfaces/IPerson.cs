using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsApp.Interfaces
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
    }
}

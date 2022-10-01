using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Models
{
    public class Employee : SameProperties
    {
        public string surname { get; set; }
        public int salary { get; set; }
        public string profession { get; set; }
        public Employee(string surname, int salary, string profession)
        {
            this.surname = surname;
            this.salary = salary;
            this.profession = profession;
        }
    }
}

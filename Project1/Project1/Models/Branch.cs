using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Models
{
    public class Branch : SameProperties
    {
        public string address { get; set; }
        public int budget { get; set; }
        public List<Employee> employees { get; set; }
        public Branch(string address, int budget, List<Employee> employees)
        {
            this.address = address;
            this.budget = budget;
            this.employees = employees;
        }
    }
}

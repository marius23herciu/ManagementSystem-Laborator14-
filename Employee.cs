using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_
{
    class Employee
    {
        public string Name { get; private set; }
        public Guid ID { get; private set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            this.Name = name;
            this.ID = Guid.NewGuid();
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $"{Name} with ID {ID} has the following salary: {Salary} RON .";
        }
    }
}

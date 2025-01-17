using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    // Define Nurse inheriting from the StaffMember class
    internal class Nurse : StaffMember
    {
        string? qualification;

        // Constructor that calls the base (super) constructor
        public Nurse(int id, string name, int age, string jobTitle, double salary, string qualification) : base(id, name, age, jobTitle, salary)
        {
            this.qualification = qualification;
        }

        // Override the sleep method (originally an abstract from the Person class)
        public override void Sleep()
        {
            Console.WriteLine($"{GetName()} the nurse slept in their house");
        }

        public override string ToString()
        {
            return $"Nurse id: {id}, Name: {GetName()}, Age: {GetAge()}, Job Title: {jobTitle}";
        }
    }
}

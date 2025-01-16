using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    internal class Nurse : StaffMember
    {
        string qualification;

        public Nurse(int id, string name, int age, string jobTitle, double salary, string qualification) : base(id, name, age, jobTitle, salary)
        {
            this.qualification = qualification;
        }

        public override void Sleep()
        {
            Console.WriteLine($"{GetName()} the nurse slept in their house");
        }

        public override string ToString()
        {
            return $"Nurse id: {id}, Name: {GetName()}, Age: {GetAge()}, Role: {jobTitle}";
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    internal class Guard : StaffMember
    {
        bool isArmed;

        public Guard(int id, string name, int age, string jobTitle, double salary, bool isArmed) : base(id, name, age, jobTitle, salary)
        {
            this.isArmed = isArmed;
        }

        public override void Sleep()
        {
            Console.WriteLine($"{GetName()} the guard slept in their house");
        }

        public override string ToString()
        {
            return $"Guard id: {id}, Name: {GetName()}, Age: {GetAge()}, Role: {GetJobTitle()}";
        }
}

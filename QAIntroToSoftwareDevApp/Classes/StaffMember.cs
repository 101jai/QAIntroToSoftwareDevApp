using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    internal class StaffMember : Person
    {
        public int id;
        public string jobTitle;
        double salary;

        public StaffMember(int id, string name, int age, string jobTitle, double salary) : base(name, age)
        {
            this.id = id;
            this.jobTitle = jobTitle;
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }

        public string GetJobTitle()
        {
            return jobTitle;
        }

        public override void Sleep()
        {
            Console.WriteLine($"{GetName()} went home to sleep"); ;
        }

        public override string ToString()
        {
            return $"Staff Member id: {id}, Name: {GetName()}, Age: {GetAge()}, Role: {role}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    public enum RiskLevel
    {
        LOW,
        MEDIUM,
        HIGH
    }

    public class Prisoner : Person
    {
        public int id;
        DateTime? releaseDate;
        RiskLevel riskLevel;
        string crime;

        public Prisoner(int id, string name, int age, string crime, RiskLevel riskLevel) : base(name, age)
        {
            this.id = id;
            this.crime = crime;
            this.riskLevel = riskLevel;
        }

        public Prisoner(int id, string name, int age, string crime, DateTime? releaseDate, RiskLevel riskLevel) : base(name, age)
        {
            this.id = id;
            this.crime = crime;
            this.releaseDate = releaseDate;
            this.riskLevel = riskLevel;
        }

        public override void Sleep()
        {
            Console.WriteLine($"{GetName()} slept in their cell");
        }

        public override string ToString()
        {
            return $"Prisoner id: {id}, Name: {GetName()}, Age: {GetAge()}, Crime: {crime}, Risk Level: {riskLevel}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    // Uses IPrison interface
    public class Prison : IPrison
    {
        string name;
        string location;
        List<Cell> cells;
        List<StaffMember> staffMembers;

        int currentCellNumber = 0;
        int currentStaffId = 0;

        // Constructor
        public Prison(string name, string location)
        {
            this.name = name;
            this.location = location;
            cells = new List<Cell>();
            staffMembers = new List<StaffMember>();
        }

        // Get functions which are required from the IPrison interface
        public List<Prisoner> GetPrisoners()
        {
            List<Prisoner> prisoners = new List<Prisoner>();
            foreach(Cell cell in cells)
            {
                foreach(Prisoner prisoner in cell.GetPrisoners())
                {
                    prisoners.Add(prisoner);
                }
            }
            return prisoners;
        }

        public List<StaffMember> GetStaffMembers()
        {
            return staffMembers;
        }

        public int GetCapacity()
        {
            int capacity = 0;
            foreach (Cell cell in cells)
            {
                capacity += cell.GetCapacity();
            }
            return capacity;
        }

        public List<Cell> GetCells()
        {
            return cells;
        }

        public void AddCell(int capacity)
        {
            cells.Add(new Cell(currentCellNumber, capacity));
            currentCellNumber++;
        }

        public void AddPrisoner(Prisoner prisoner)
        {
            if (GetPrisoners().Count < GetCapacity())
            {
                cells.Where(cell => cell.GetCapacity() > cell.GetPrisonerCount()).First().AddPrisoner(prisoner);
            }
            else
            {
                throw new Exception("Prison is at full capacity");
            }
        }

        public void RemovePrisoner(int id)
        {
            if (GetPrisoners().Count > 0)
            {
                if(cells.Any(p => p.GetPrisoners().Any(p => p.id == id)))
                {
                    cells.Where(cell => cell.GetPrisoners().Any(p => p.id == id)).First().RemovePrisoner(id);
                }
                else
                {
                    throw new Exception("Prisoner not found in prison");
                }
            }
            else
            {
                throw new Exception("Prison is empty");
            }
        }

        // function for adding nurses to the prison
        public void AddNurse(string name, int age, string jobTitle)
        {
            Console.WriteLine("What is the Nurse's qualification(s)?");
            string qualification = Console.ReadLine();
            double salary = 0;
            bool hasSalary = false;
            while (!hasSalary)
            {
                Console.WriteLine("What is the Nurse's Salary?");
                hasSalary = Double.TryParse(Console.ReadLine(), out salary);
            }

            staffMembers.Add(new Nurse(currentStaffId, name, age, jobTitle, salary, qualification));
            currentStaffId++;
        }

        //Function for adding guards to the prison
        public void AddGuard(string name, int age, string jobTitle, bool isArmed)
        {
            Console.WriteLine("What is the Nurse's qualification(s)?");
            double salary = 0;
            bool hasSalary = false;
            while (!hasSalary)
            {
                Console.WriteLine("What is the Guard's Salary?");
                hasSalary = Double.TryParse(Console.ReadLine(), out salary);
            }

            staffMembers.Add(new Guard(currentStaffId, name, age, jobTitle, salary, isArmed));
            currentStaffId++;
        }
    }
}
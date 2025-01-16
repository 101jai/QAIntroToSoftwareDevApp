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

        public int GetCapacity()
        {
            int capacity = 0;
            foreach (Cell cell in cells)
            {
                capacity += cell.GetCapacity();
            }
            return capacity;
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    public class Cell
    {
        int cellNumber;
        int capacity;
        List<Prisoner> prisoners;

        public Cell(int cellNumber, int capacity)
        {
            this.cellNumber = cellNumber;
            this.capacity = capacity;
            prisoners = new List<Prisoner>();
        }

        public List<Prisoner> GetPrisoners()
        {
            return prisoners;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        public int GetPrisonerCount()
        {
            return prisoners.Count;
        }

        public void AddPrisoner(Prisoner prisoner)
        {
            if (prisoners.Count < capacity)
            {
                prisoners.Add(prisoner);
            }
            else
            {
                throw new Exception("Cell is at full capacity");
            }
        }

        public void RemovePrisoner(int id)
        {
            if (prisoners.Count > 0)
            {
                if(!prisoners.Any(p => p.id == id))
                {
                    throw new Exception("Prisoner not found in cell #" + cellNumber);
                }
                prisoners.Remove(prisoners.FirstOrDefault(p => p.id == id));
            }
            else
            {
                throw new Exception($"Cell #{cellNumber} is empty, cannot remove prisoner");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    internal interface IPrison
    {
        int GetCapacity();
        void AddCell(int capacity);
        void AddPrisoner(Prisoner prisoner);
        void RemovePrisoner(int id);
    }
}

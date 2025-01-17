using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAIntroToSoftwareDevApp.Classes
{
    // Declare interface for Prison class, could be extended to other prison types (High security etc)
    internal interface IPrison
    {
        int GetCapacity();
        void AddCell(int capacity);
        void AddPrisoner(Prisoner prisoner);
        void RemovePrisoner(int id);
    }
}

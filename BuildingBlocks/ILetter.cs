using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace BuildingBlocks
{
    public interface ILetter
    {
        void DisplayLetterInfo();

        bool IsC(List<int> directions);
        bool IsI(List<int> directions);
        bool IsL(List<int> directions);
        bool IsM(List<int> directions);
        bool IsN(List<int> directions);
        bool IsO(List<int> directions);
        bool IsR(List<int> directions);
        bool IsS(List<int> directions);
        bool IsW(List<int> directions);
        
    }
}

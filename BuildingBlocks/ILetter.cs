using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace BuildingBlocks
{
    public interface ILetter:Directional
    {
        void displayLetterInfo();
        void setLetterDirection(int letterDirection);
        Plane getOnPlane();
        bool getSmaller();

        bool isC(List<int> directions);
        bool isI(List<int> directions);
        bool isL(List<int> directions);
        bool isM(List<int> directions);
        bool isN(List<int> directions);
        bool isO(List<int> directions);
        bool isR(List<int> directions);
        bool isS(List<int> directions);
        bool isW(List<int> directions);
        
    }
}

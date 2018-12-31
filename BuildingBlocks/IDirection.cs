using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks
{
    public interface IDirection : Directional
    {
        void setDirectionLength(float directionLength);
        bool isDirectionValid(int direction);
        void setCanShootList(List<bool> canShootList);
        void setDirectionDivisor(float directionDivisor);
        float getDirectionLength();
        float getDirectionDivisor();
    }
}

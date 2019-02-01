using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks
{
    public interface IDirection : Directional
    {
        void SetDirectionLength(float directionLength);
        bool IsDirectionValid(int direction);
        void SetCanShootList(List<bool> canShootList);
        void SetDirectionDivisor(float directionDivisor);
        float GetDirectionLength();
        float GetDirectionDivisor();
    }
}
